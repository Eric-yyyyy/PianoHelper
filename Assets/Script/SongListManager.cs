using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SongListManager : MonoBehaviour
{
    public GameObject songItemTemplate;  
    public Transform content;  
    public PlayerSound playerSound;  

    void Start()
    {
        PopulateSongList();
    }

    void PopulateSongList()
    {
        CreateSongButton("Twinkle Twinkle Little Star", new Twinckle());
        CreateSongButton("Laputua: Castle In The Sky", new CastleCity());
        CreateSongButton("Happy Birthday", new HappyBirthday());
    }

    void CreateSongButton(string songName, ISong songInstance)
    {
        GameObject songButton = Instantiate(songItemTemplate, content);
        songButton.SetActive(true);  
        songItemTemplate.SetActive(false);


    
    TMP_Text songText = songButton.GetComponentInChildren<TMP_Text>();
        if (songText != null) songText.text = songName;
        Button button = songButton.GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(() => OnSongSelected(songInstance));
        }
    }

    void OnSongSelected(ISong song)
    {
        if (playerSound != null)
        {
            playerSound.SelectSong(song);
        }
    }
}

