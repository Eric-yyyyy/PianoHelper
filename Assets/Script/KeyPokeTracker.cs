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

        // Override ToString for each KeyPokeInfo entry
        public override string ToString()
        {
            return $"Key: {keyName}, Duration: {pokeDuration:F2}s, Start: {pokeStartTime:F2}s";
        }
    }

    private List<KeyPokeInfo> keyPokeOrder = new List<KeyPokeInfo>();

    public void AddKeyPoke(string keyName, float pokeStartTime, float pokeDuration)
    {
        KeyPokeInfo pokeInfo = new KeyPokeInfo
        {
            keyName = keyName,
            pokeDuration = pokeDuration,
            pokeStartTime = pokeStartTime
        };
        keyPokeOrder.Add(pokeInfo);

        // Convert the list to a formatted string for display
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
