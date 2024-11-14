using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class VolumeController : MonoBehaviour
{
    public GameObject fixedPiano;          // Reference to the fixedPiano GameObject
    public Slider volumeSlider;            // Reference to the UI Slider
    public Button increaseVolumeButton;    // Reference to the Increase Volume button
    public Button decreaseVolumeButton;    // Reference to the Decrease Volume button
    private List<AudioSource> keyAudioSources = new List<AudioSource>();
    private float volumeStep = 0.05f;      // The step value for each button press

    void Start()
    {
        // Find and store all AudioSources under key115
        if (fixedPiano != null)
        {
            Transform key115 = fixedPiano.transform.Find("key115");
            if (key115 != null)
            {
                foreach (Transform key in key115)
                {
                    AudioSource audioSource = key.GetComponentInChildren<AudioSource>();
                    if (audioSource != null)
                    {
                        keyAudioSources.Add(audioSource);
                    }
                    else
                    {
                        Debug.LogWarning($"No AudioSource found for key: {key.name}");
                    }
                }
            }
            else
            {
                Debug.LogError("key115 not found under fixedPiano.");
            }
        }
        else
        {
            Debug.LogError("FixedPiano reference not set.");
        }

        // Set initial volume based on the slider value
        SetVolume(volumeSlider.value);

        // Add listener to the slider to update volume
        volumeSlider.onValueChanged.AddListener(SetVolume);

        // Add listeners to the buttons for increasing and decreasing volume
        increaseVolumeButton.onClick.AddListener(IncreaseVolume);
        decreaseVolumeButton.onClick.AddListener(DecreaseVolume);
    }

    // Method to set volume across all AudioSources
    void SetVolume(float volume)
    {
        foreach (AudioSource audioSource in keyAudioSources)
        {
            audioSource.volume = volume;
        }
    }

    // Method to increase the volume
    void IncreaseVolume()
    {
        float newVolume = Mathf.Clamp(volumeSlider.value + volumeStep, 0f, 1f);
        volumeSlider.value = newVolume;
    }

    // Method to decrease the volume
    void DecreaseVolume()
    {
        float newVolume = Mathf.Clamp(volumeSlider.value - volumeStep, 0f, 1f);
        volumeSlider.value = newVolume;
    }
}
