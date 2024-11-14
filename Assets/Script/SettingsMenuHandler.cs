using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuHandler : MonoBehaviour
{
    public GameObject settingsCanvas;   // Canvas or parent object containing all menu elements
    public Button exitButton;           // Reference to the Exit button

    private bool isMenuVisible = true;  // Track visibility state of the menu

    private void Start()
    {
        exitButton.onClick.AddListener(ToggleMenuVisibility); // Add listener to the Exit button

        // Ensure all elements are initially visible except the Exit button if desired
        SetMenuElementsVisibility(isMenuVisible);
    }

    private void ToggleMenuVisibility()
    {
        isMenuVisible = !isMenuVisible; // Toggle the visibility state
        SetMenuElementsVisibility(isMenuVisible); // Toggle visibility of all menu elements
    }

    private void SetMenuElementsVisibility(bool visible)
    {
        foreach (Transform child in settingsCanvas.transform)
        {
            // Toggle each element except the Exit button
            if (child.gameObject != exitButton.gameObject && child.gameObject.name != "Collider" &&
                child.gameObject.name != "PlaneSurface" && child.gameObject.name != "Finish" && child.gameObject.name != "SongItemTemplate")
            {
                child.gameObject.SetActive(visible);
            }
        }
    }


}
