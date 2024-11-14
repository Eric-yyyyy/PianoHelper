using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyIsPoked : MonoBehaviour
{
    private bool isPoked;
    private float pokeStartTime;
    private float pokeDuration;
    private bool isChanged;

    public KeyPokeTracker keyPokeTracker;

    void Start()
    {
        isPoked = false;
        isChanged = false;
        pokeStartTime = 0f;
        pokeDuration = 0f;

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
        }
        isPoked = true;

        // Update the KeyPokeTracker entry
        if (keyPokeTracker != null)
        {
            isChanged = true;
            //keyPokeTracker.AddOrUpdateKeyPoke(gameObject.name, pokeStartTime, pokeDuration, isPoked, isChanged);
        }
    }

    public void SetIsPokedToFalse()
    {
        if (isPoked)
        {
            pokeDuration = Time.time - pokeStartTime;
            Debug.Log("Poke Duration: " + pokeDuration + " seconds");

            // Update the KeyPokeTracker entry
            if (keyPokeTracker != null)
            {
                isChanged = true;
                keyPokeTracker.AddOrUpdateKeyPoke(gameObject.name, pokeStartTime, pokeDuration, false, isChanged);
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
