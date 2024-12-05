using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaceController : MonoBehaviour
{
    public Slider paceSlider; // Reference to the slider
    public Button minusButton; // Reference to the "-" button
    public Button plusButton; // Reference to the "+" button
    public PlayerSound playerSound; // Reference to the PlayerSound script
    public float stepAmount = 0.05f; // Amount to step the slider value

    void Start()
    {
        // Attach button click listeners
        if (minusButton != null)
        {
            minusButton.onClick.AddListener(DecreasePace);
        }
        if (plusButton != null)
        {
            plusButton.onClick.AddListener(IncreasePace);
        }

        // Update the PlayerSound multiplier whenever the slider value changes
        if (paceSlider != null)
        {
            paceSlider.onValueChanged.AddListener(UpdatePaceMultiplier);
            UpdatePaceMultiplier(paceSlider.value); // Set initial multiplier
        }
    }

    // Decrease pace (move slider to the left = faster)
    void DecreasePace()
    {
        if (paceSlider != null)
        {
            paceSlider.value = Mathf.Clamp(paceSlider.value - stepAmount, paceSlider.minValue, paceSlider.maxValue);
        }
    }

    // Increase pace (move slider to the right = slower)
    void IncreasePace()
    {
        if (paceSlider != null)
        {
            paceSlider.value = Mathf.Clamp(paceSlider.value + stepAmount, paceSlider.minValue, paceSlider.maxValue);
        }
    }

    // Update the speed multiplier in the PlayerSound script
    void UpdatePaceMultiplier(float sliderValue)
    {
        if (playerSound != null)
        {
            // Directly map slider value to the speed multiplier
            float adjustedMultiplier = sliderValue; // Left = smaller value = faster, Right = larger value = slower
            playerSound.speedMultiplier = adjustedMultiplier;

            Debug.Log("Updated Speed Multiplier: " + adjustedMultiplier); // For debugging
        }
    }
}

