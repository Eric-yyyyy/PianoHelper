using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SongListManager : MonoBehaviour
{
    public GameObject songItemTemplate;  // Template for each song item
    public Transform content;            // ScrollView content area
    public PlayerSound playerSound;      // Reference to the PlayerSound script

    void Start()
    {
        PopulateSongList();
    }

    // Populates the scroll view with songs
    void PopulateSongList()
    {
        CreateSongButton("Twinkle Twinkle Little Star", new Twinckle());
        
    }

    // Creates a button in the scroll view for each song
    void CreateSongButton(string songName, ISong songInstance)
    {
        GameObject songButton = Instantiate(songItemTemplate, content);
        songButton.SetActive(true);  // Ensure the button is visible
        songItemTemplate.SetActive(false);


    // Set the song name text on the button
    TMP_Text songText = songButton.GetComponentInChildren<TMP_Text>();
        if (songText != null) songText.text = songName;

        // Attach the click event to play the song
        Button button = songButton.GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(() => OnSongSelected(songInstance));
        }
    }


    // Triggered when a song is selected from the list
    void OnSongSelected(ISong song)
    {
        if (playerSound != null)
        {
            playerSound.SelectSong(song);
        }
    }
}

