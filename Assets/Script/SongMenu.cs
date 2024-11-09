using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongMenu : MonoBehaviour
{
    ArrayList SongList = new ArrayList();
    void Start()
    {
        AddSong("TTLS");
        AddSong("Happy Birthday");
    }
    public void AddSong(string SongName)
    {
        SongList.Add(SongName);
    }

  
}
