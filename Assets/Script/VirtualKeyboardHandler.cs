using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VirtualKeyboardHandler : MonoBehaviour
{
    public Button inputFieldButton;          
    public GameObject virtualKeyboard;       

    private void Start()
    {
        virtualKeyboard.SetActive(false); 

        inputFieldButton.onClick.AddListener(ShowKeyboard);
    }

    private void ShowKeyboard()
    {
        virtualKeyboard.SetActive(true); 
    }

    private void Update()
    {

        if (virtualKeyboard.activeSelf && Input.GetKeyDown(KeyCode.Return))
        {
            HideKeyboard();
        }
    }

    private void HideKeyboard()
    {
        virtualKeyboard.SetActive(false); 
    }

    private void OnDestroy()
    {
        
        inputFieldButton.onClick.RemoveListener(ShowKeyboard);
    }
}

