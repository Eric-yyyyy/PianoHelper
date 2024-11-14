using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TwinkleManager : MonoBehaviour
{
    public KeyPokeTracker keyPokeTracker;
    public RawImage image1; 
    public RawImage image2; 
    public RawImage image3; 
    public GameObject report;
    private int errorKeys;
    private float durationTime;
    public TextMeshProUGUI SongName;
    public TextMeshProUGUI UsedTime;
    public TextMeshProUGUI AccuracyRate;
    private int currentHighlightIndex = 0;
    private bool keyPokedAndReset = true;
    private float delayBetweenNotes = 0.5f; 
    private float delayTimer = 0f;
    
    private List<KeyPokeTracker.KeyPokeInfo> totalPokeOrder = new List<KeyPokeTracker.KeyPokeInfo>();
    private List<KeyPokeTracker.KeyPokeInfo> CheckSequenceList = new List<KeyPokeTracker.KeyPokeInfo>();
    private readonly List<string> targetSequence1 = new List<string> { "C3","C3","G3","G3","A4","A4","G3","F3", "F3", "E3", "E3", "D3", "D3", "C3" };
    private readonly List<string> targetleftSequence1 = new List<string> {"E2","E2","E2","E2","F2","F2","E2","D2","D2","C2","C2", "B2", "B2", "C2" };
    private readonly List<string> targetSequence2 = new List<string> { "G3", "G3", "F3", "F3", "E3", "E3", "D3", "G3", "G3", "F3", "F3", "E3", "E3", "D3"};
    private readonly List<string> targetleftSequence2 = new List<string> { "E2", "E2", "D2", "D2", "C2", "C2", "B2", "E2", "E2", "D2", "D2", "C2", "C2", "B2"}; 
    private readonly List<string> targetSequence3 = new List<string>{ "C3","C3","G3","G3","A4","A4","G3","F3", "F3", "E3", "E3", "D3", "D3", "C3" };
    private readonly List<string> targetleftSequence3 = new List<string>{"E2","E2","E2","E2","F2","G2","A3","B3","C3","D2","A3", "G2", "C2", "G2","A2","C2" };
    private readonly List<string> righthand = new List<string>{"C3","C3","G3","G3","A4","A4","G3","F3", "F3", "E3", "E3", "D3", "D3", "C3","G3", "G3", "F3", "F3", "E3", "E3", "D3", "G3", "G3", "F3", "F3", "E3", "E3", "D3",  "C3","C3","G3","G3","A4","A4","G3","F3", "F3", "E3", "E3", "D3", "D3", "C3" };
    private readonly List<string> lefthand = new List<string>{"E2","E2","E2","E2","F2","F2","E2","D2","D2","C2","C2", "B2", "B2", "C2" ,"E2", "E2", "D2", "D2", "C2", "C2", "B2", "E2", "E2", "D2", "D2", "C2", "C2", "B2", "E2","E2","E2","E2","F2","G2","A3","B3","C3","D2","A3", "G2", "C2", "G2","A2","C2" };
    private bool isFirstSequenceCompleted = false;
    private bool isSecondSequenceCompleted = false;
    private bool isThirdSequenceCompleted = false;
    public Dictionary<string, GameObject> pianoKeys;
    public Material highlightedMaterial;
    public Material defaultMaterial;
    List<KeyPokeTracker.KeyPokeInfo> pokeOrder; 
    private void Start()
    {
        keyPokeTracker.ClearKeyPokeOrder();
        errorKeys = 0;
        durationTime = 0f;
        
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

        pokeOrder = keyPokeTracker.GetKeyPokeOrder();
        
        ChangeMaterial();
        if (!isFirstSequenceCompleted && CheckSequenceList.Count >= targetSequence1.Count &&
            (CheckAndCalculateSequence(CheckSequenceList, targetSequence1) || CheckAndCalculateSequence(CheckSequenceList, targetleftSequence1)))
        {
            image1.gameObject.SetActive(false);
            image2.gameObject.SetActive(true);
            isFirstSequenceCompleted = true;
            //ChangeMaterial();
            CheckSequenceList.Clear();
        }
        else if (isFirstSequenceCompleted && !isSecondSequenceCompleted && CheckSequenceList.Count >= targetSequence2.Count &&
                 (CheckAndCalculateSequence(CheckSequenceList, targetSequence2) || CheckAndCalculateSequence(CheckSequenceList, targetleftSequence2)))
        {
            image2.gameObject.SetActive(false);
            image3.gameObject.SetActive(true);
            isSecondSequenceCompleted = true;
            //ChangeMaterial();
            CheckSequenceList.Clear();
        }
        else if (isSecondSequenceCompleted && !isThirdSequenceCompleted && CheckSequenceList.Count >= targetSequence3.Count &&
                 (CheckAndCalculateSequence(CheckSequenceList, targetSequence3) || CheckAndCalculateSequence(CheckSequenceList, targetleftSequence3)))
        {
            image3.gameObject.SetActive(false);
            isThirdSequenceCompleted = true;
            //ChangeMaterial();
            CheckSequenceList.Clear();
        }
        else if (isThirdSequenceCompleted)
        {
            DisplayReport();
        }
    }

    private bool CheckAndCalculateSequence(List<KeyPokeTracker.KeyPokeInfo> pokeOrder, List<string> targetSequence)
    {
        int targetIndex = 0;
        //ChangeMaterial();
        foreach (var pokeInfo in pokeOrder)
        {
            if (!totalPokeOrder.Contains(pokeInfo))
            {
                totalPokeOrder.Add(pokeInfo);
                durationTime += pokeInfo.pokeDuration;
            }

            if (pokeInfo.keyName == targetSequence[targetIndex])
            {
                targetIndex++;
                if (targetIndex == targetSequence.Count) return true;
            }
            else
            {
                errorKeys++;
            }
        }
        //ChangeMaterial();
        return false;
    }

    private void DisplayReport()
    {
        report.SetActive(true);
        SongName.text = "Twinkle Twinkle Little Star";
        UsedTime.text = durationTime.ToString("F2") + " seconds";
        errorKeys = (totalPokeOrder.Count >= 86)? totalPokeOrder.Count - 86 : 86 - totalPokeOrder.Count;
        AccuracyRate.text = ((86 - errorKeys) / 86f * 100).ToString("F2") + "%";
    }

    public void ActivateImage1()
    {
        keyPokeTracker.ClearKeyPokeOrder();
        image1.gameObject.SetActive(true);
        image2.gameObject.SetActive(false);
        image3.gameObject.SetActive(false);
        report.SetActive(false);
        isFirstSequenceCompleted = false;
        isSecondSequenceCompleted = false;
        isThirdSequenceCompleted = false;
        currentHighlightIndex = 0;
    }
public void ChangeMaterial()
{
    if (currentHighlightIndex >= righthand.Count) return; // Stop if all notes are highlighted

    GameObject key = pianoKeys[righthand[currentHighlightIndex]];
    MeshRenderer renderer = key.GetComponent<MeshRenderer>();

    // Only highlight if the current key has been reset
    if (keyPokedAndReset)
    {
        renderer.material = highlightedMaterial;
        keyPokedAndReset = false; // Mark as highlighted
    }

    // Check if the current key has been poked
    if (pokeOrder.Count > 0 && string.Equals(pokeOrder[pokeOrder.Count - 1].keyName, righthand[currentHighlightIndex]))
    {
        ResetMaterial(righthand[currentHighlightIndex]); // Reset the material to default
        keyPokedAndReset = true; // Mark as ready for the next note
        currentHighlightIndex++; // Move to the next note
        if (!CheckSequenceList.Contains(pokeOrder[pokeOrder.Count - 1]))
            {
                CheckSequenceList.Add(pokeOrder[pokeOrder.Count - 1]);
               
            }
        keyPokeTracker.ClearKeyPokeOrder(); // Clear the poke order to track the next note separately
    }
}

public void ResetMaterial(string noteName)
{
    GameObject key = pianoKeys[noteName];
    MeshRenderer renderer = key.GetComponent<MeshRenderer>();
    renderer.material = defaultMaterial;
}





    // public void ResetMaterial(string String ){
    //     GameObject key = pianoKeys[String];
    //     MeshRenderer renderer = key.GetComponent<MeshRenderer>();
    //     renderer.material = defaultMaterial;
    //      keyPokedAndReset = true; 
    // }



}