using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPiano : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Piano_88;
    public GameObject Piano_76;
    public GameObject Piano_61;
    public Button FinishButton;
    public GameObject SettingCanvas;
    public Toggle PianoStatus88;
    public Toggle PinaoStatus76;
    public Toggle PianoStatus61;
    void Start()
    {
        FinishButton.onClick.AddListener(ShowPiano);
    }

    // Update is called once per frame
    public void ShowPiano()
    {
        if (PianoStatus88.isOn)
        {
            Piano_76.SetActive(false);
            Piano_61.SetActive(false);
            Piano_88.SetActive(true);
       
        }
            if (PinaoStatus76.isOn)
        {
            Piano_76.SetActive(true);
            Piano_88.SetActive(false);
            Piano_61.SetActive(false);
        }
            if (PianoStatus61.isOn)
        {
            Piano_61.SetActive(true);
            Piano_88.SetActive(false);
            Piano_76.SetActive(false);
        }
        
    }
}
