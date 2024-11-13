using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwinkleManager : MonoBehaviour
{
    public KeyPokeTracker keyPokeTracker;
    public RawImage image1; // Initial image
    public RawImage image2; // Image after first sequence
    public RawImage image3; // Image after second sequence

    private readonly List<string> targetSequence1 = new List<string> { "F3", "F3", "E3", "E3", "D3", "D3", "C3" };
    private readonly List<string> targetleftSequence1 = new List<string> { "B2", "B2", "C2" };
    private readonly List<string> targetSequence2 = new List<string> { "G3", "G3", "F3", "F3", "E3", "E3", "D3", "G3", "G3", "F3", "F3", "E3", "E3", "D3"};
    private readonly List<string> targetleftSequence2 = new List<string> { "E2", "E2", "D2", "D2", "C2", "C2", "B2", "E2", "E2", "D2", "D2", "C2", "C2", "B2"}; // Example second sequence

    private bool isFirstSequenceCompleted = false;

    private void Start()
    {
        keyPokeTracker.ClearKeyPokeOrder();
        if (keyPokeTracker == null)
        {
            Debug.LogError("KeyPokeTracker not assigned in TwinkleManager.");
        }

        image1.gameObject.SetActive(false);  // Start with image1
        image2.gameObject.SetActive(false); // Set image2 inactive
        image3.gameObject.SetActive(false); // Set image3 inactive
    }

    private void Update()
    {
        if (keyPokeTracker == null) return;

        // Get the current poke sequence from KeyPokeTracker
        List<KeyPokeTracker.KeyPokeInfo> pokeOrder = keyPokeTracker.GetKeyPokeOrder();

        // Check for the first sequence if it hasn't been completed
        if (!isFirstSequenceCompleted && pokeOrder.Count >= targetSequence1.Count && (IsSequencePresent(pokeOrder, targetSequence1) || IsSequencePresent(pokeOrder, targetleftSequence1)))
        {
            image1.gameObject.SetActive(false);
            image2.gameObject.SetActive(true);
            isFirstSequenceCompleted = true;

            // Clear the order for the next sequence
            keyPokeTracker.ClearKeyPokeOrder();
        }
        // Check for the second sequence after the first one is completed
        else if (isFirstSequenceCompleted && pokeOrder.Count >= targetSequence2.Count && (IsSequencePresent(pokeOrder, targetSequence2) || IsSequencePresent(pokeOrder, targetleftSequence2)))
        {
            image2.gameObject.SetActive(false);
            image3.gameObject.SetActive(true);

            // Clear the order for any further sequences
            keyPokeTracker.ClearKeyPokeOrder();
        }
    }

    private bool IsSequencePresent(List<KeyPokeTracker.KeyPokeInfo> pokeOrder, List<string> targetSequence)
    {
        int targetIndex = 0;

        foreach (var pokeInfo in pokeOrder)
        {
            if (pokeInfo.keyName == targetSequence[targetIndex])
            {
                targetIndex++;
                if (targetIndex == targetSequence.Count)
                {
                    return true; // Sequence is found
                }
            }
        }

        return false; // Sequence not found
    }
    public void ActivateImage1(){
        keyPokeTracker.ClearKeyPokeOrder();
        image1.gameObject.SetActive(true);
        image2.gameObject.SetActive(false);
        image3.gameObject.SetActive(false);
    }
}
