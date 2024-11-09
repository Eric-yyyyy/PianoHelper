using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRARToggleController : MonoBehaviour
{
    [Header("VR and AR Toggles")]
    public Toggle toggleVR; 
    public Toggle toggleAR; 

    [Header("Piano Key Toggles")]
    public Toggle piano88;
    public Toggle piano76;
    public Toggle piano61;

    [Header("Music Sheet Toggles")]
    public Toggle MusicSheetDropping;
    public Toggle MusicSheetAutoScroll;

    private void Start()
    {
        
        toggleVR.onValueChanged.AddListener(OnVRToggleChanged);
        toggleAR.onValueChanged.AddListener(OnARToggleChanged);


        piano88.onValueChanged.AddListener(OnPiano88ToggleChanged);
        piano76.onValueChanged.AddListener(OnPiano76ToggleChanged);
        piano61.onValueChanged.AddListener(OnPiano61ToggleChanged);

   
        MusicSheetDropping.onValueChanged.AddListener(OnDroppingToggleChanged);
        MusicSheetAutoScroll.onValueChanged.AddListener(OnAutoScrollToggleChanged);

      
        toggleVR.isOn = true; 
        piano88.isOn = true;
        MusicSheetDropping.isOn = true;
    }

    private void OnVRToggleChanged(bool isOn)
    {
        if (isOn)
        {
          
            toggleAR.isOn = false;

            ActivateVRMode();
        }
    }

    private void OnARToggleChanged(bool isOn)
    {
        if (isOn)
        {
            
            toggleVR.isOn = false;

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

    }

    private void ActivateARMode()
    {
        Debug.Log("AR mode activated");
      
    }


}
