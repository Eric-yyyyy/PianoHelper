using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyIsPoked : MonoBehaviour
{
    private bool isPoked;
    private float pokeStartTime;
    private float pokeDuration;
    //public TextMeshProUGUI  text;


    // Reference to the KeyPokeTracker
    public KeyPokeTracker keyPokeTracker;

    void Start()
    {
        isPoked = false;
        pokeStartTime = 0f;
        pokeDuration = 0f;

        // Find the KeyPokeTracker in the scene if not assigned
        if (keyPokeTracker == null)
        {
            keyPokeTracker = FindObjectOfType<KeyPokeTracker>();
            if (keyPokeTracker == null)
            {
                Debug.LogError("KeyPokeTracker not found in the scene. Please add it.");
            }
        }
    }

    public void SetIsPokedToTrue()
    {
        if (!isPoked)
        {
            pokeStartTime = Time.time;
            //text.text = gameObject.name;
        }
        isPoked = true;
    }

    public void SetIsPokedToFalse()
    {
        if (isPoked)
        {
            pokeDuration = Time.time - pokeStartTime;
            Debug.Log("Poke Duration: " + pokeDuration + " seconds");

            // Add this poke data to the KeyPokeTracker
            if (keyPokeTracker != null)
            {
                keyPokeTracker.AddKeyPoke(gameObject.name, pokeStartTime, pokeDuration);
            }
        }
        isPoked = false;
    }

    public bool GetIsPoked()
    {
        return isPoked;
    }

    public float GetPokeDuration()
    {
        return pokeDuration;
    }
}
