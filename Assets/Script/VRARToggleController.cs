using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRARToggleController : MonoBehaviour
{
    [Header("VR and AR Toggles")]
    public Toggle toggleVR; // Assign the VR toggle here
    public Toggle toggleAR; // Assign the AR toggle here

    [Header("Piano Key Toggles")]
    public Toggle piano88;
    public Toggle piano76;
    public Toggle piano61;

    [Header("Music Sheet Toggles")]
    public Toggle MusicSheetDropping;
    public Toggle MusicSheetAutoScroll;

    private void Start()
    {
        // Subscribe to the toggle events for VR and AR
        toggleVR.onValueChanged.AddListener(OnVRToggleChanged);
        toggleAR.onValueChanged.AddListener(OnARToggleChanged);

        // Subscribe to the toggle events for piano keys
        piano88.onValueChanged.AddListener(OnPiano88ToggleChanged);
        piano76.onValueChanged.AddListener(OnPiano76ToggleChanged);
        piano61.onValueChanged.AddListener(OnPiano61ToggleChanged);

        // Subscribe to the toggle events for music sheets
        MusicSheetDropping.onValueChanged.AddListener(OnDroppingToggleChanged);
        MusicSheetAutoScroll.onValueChanged.AddListener(OnAutoScrollToggleChanged);

        // Optionally set initial state, if needed
        toggleVR.isOn = true; // Or toggleAR.isOn = true based on the default mode
        piano88.isOn = true;
        MusicSheetDropping.isOn = true;
    }

    private void OnVRToggleChanged(bool isOn)
    {
        if (isOn)
        {
            // Ensure AR toggle is turned off when VR is selected
            toggleAR.isOn = false;

            // Execute additional logic for VR mode
            ActivateVRMode();
        }
    }

    private void OnARToggleChanged(bool isOn)
    {
        if (isOn)
        {
            // Ensure VR toggle is turned off when AR is selected
            toggleVR.isOn = false;

            // Execute additional logic for AR mode
            ActivateARMode();
        }
    }

    private void OnPiano88ToggleChanged(bool isOn)
    {
        if (isOn)
        {
            piano76.isOn = false;
            piano61.isOn = false;
        }
    }

    private void OnPiano76ToggleChanged(bool isOn)
    {
        if (isOn)
        {
            piano88.isOn = false;
            piano61.isOn = false;
        }
    }

    private void OnPiano61ToggleChanged(bool isOn)
    {
        if (isOn)
        {
            piano88.isOn = false;
            piano76.isOn = false;
        }
    }

    private void OnDroppingToggleChanged(bool isOn)
    {
        if (isOn)
        {
            MusicSheetAutoScroll.isOn = false;
        }
    }

    private void OnAutoScrollToggleChanged(bool isOn)
    {
        if (isOn)
        {
            MusicSheetDropping.isOn = false;
        }
    }

    private void ActivateVRMode()
    {
        Debug.Log("VR mode activated");
        // Add code to activate VR mode settings
    }

    private void ActivateARMode()
    {
        Debug.Log("AR mode activated");
        // Add code to activate AR mode settings
    }


}
