using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyPokeTracker : MonoBehaviour
{
    public TextMeshProUGUI text;

    public struct KeyPokeInfo
    {
        public string keyName;
        public float pokeDuration;
        public float pokeStartTime;
        public bool KeyIsPoked;
        public bool isChanged;

        public override string ToString()
        {
            return $"Key: {keyName}, Duration: {pokeDuration:F2}s, Start: {pokeStartTime:F2}s, KeyIsPoked: {KeyIsPoked}";
        }
    }

    private List<KeyPokeInfo> keyPokeOrder = new List<KeyPokeInfo>();

    public void AddOrUpdateKeyPoke(string keyName, float pokeStartTime, float pokeDuration, bool KeyIsPoked, bool isChanged)
    {
        // Check if an entry with the same key name and start time already exists
        int index = keyPokeOrder.FindIndex(p => p.keyName == keyName && Mathf.Approximately(p.pokeStartTime, pokeStartTime));

        if (index >= 0)
        {
            // Update existing entry
            KeyPokeInfo pokeInfo = keyPokeOrder[index];
            pokeInfo.KeyIsPoked = KeyIsPoked;
            pokeInfo.pokeDuration = pokeDuration;
            pokeInfo.isChanged = isChanged;
            keyPokeOrder[index] = pokeInfo; // Replace with updated entry
        }
        else
        {
            // Add new entry if no match is found
            KeyPokeInfo pokeInfo = new KeyPokeInfo
            {
                keyName = keyName,
                pokeDuration = pokeDuration,
                pokeStartTime = pokeStartTime,
                KeyIsPoked = KeyIsPoked,
                isChanged = isChanged,
            };
            keyPokeOrder.Add(pokeInfo);
        }

        // Update the displayed text
        text.text = string.Join("\n", keyPokeOrder);

        Debug.Log($"Key {keyName} was poked for {pokeDuration} seconds, starting at {pokeStartTime}");
    }

    public List<KeyPokeInfo> GetKeyPokeOrder()
    {
        return keyPokeOrder;
    }

    public void ClearKeyPokeOrder()
    {
        keyPokeOrder.Clear();
    }
}
