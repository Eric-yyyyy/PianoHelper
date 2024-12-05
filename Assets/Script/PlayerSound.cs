using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSound : MonoBehaviour
{
    public Dictionary<string, GameObject> pianoKeys;
    public Material highlightedMaterial;
    public Button finishButton;
    public Toggle LockNote;
    public Toggle DropNotes;
    public Toggle AutoScroll;
    public GameObject fixedPianoParent;
    public float speedMultiplier = 0.0f
    ;

    private ISong currentSong; 
    private bool isPlaying = false;
    private Queue<Notes> combinedQueue;
    private Notes currentNote;
    private float songTimer = 0f;

    private Dictionary<string, bool> keyPokedStatus = new Dictionary<string, bool>();
    private Dictionary<string, float> keyPokedDuration = new Dictionary<string, float>();
    public TwinkleManager twinkleManager;

    void Start()
    {
        InitializePianoKeys();
        twinkleManager.pianoKeys = pianoKeys;

        if (finishButton != null)
        {
            finishButton.onClick.AddListener(OnFinishButtonClicked);
        }
        else
        {
            Debug.LogError("Finish Button not assigned in the Inspector.");
        }

 
        foreach (var key in pianoKeys.Keys)
        {
            keyPokedStatus[key] = false;
            keyPokedDuration[key] = 0f;
        }
    }

    void InitializePianoKeys()
    {
        pianoKeys = new Dictionary<string, GameObject>
        {
            {"A0", fixedPianoParent.transform.Find("key115/A0Interactable/A0")?.gameObject },
            {"B0", fixedPianoParent.transform.Find("key115/B0Interactable/B0")?.gameObject },
            {"C0", fixedPianoParent.transform.Find("key115/C0Interactable/C0")?.gameObject },
            {"D0", fixedPianoParent.transform.Find("key115/D0Interactable/D0")?.gameObject },
            {"E0", fixedPianoParent.transform.Find("key115/E0Interactable/E0")?.gameObject },
            {"F0", fixedPianoParent.transform.Find("key115/F0Interactable/F0")?.gameObject },
            {"G0", fixedPianoParent.transform.Find("key115/G0Interactable/G0")?.gameObject },

            {"A1", fixedPianoParent.transform.Find("key115/A1Interactable/A1")?.gameObject },
            {"B1", fixedPianoParent.transform.Find("key115/B1Interactable/B1")?.gameObject },
            {"C1", fixedPianoParent.transform.Find("key115/C1Interactable/C1")?.gameObject },
            {"D1", fixedPianoParent.transform.Find("key115/D1Interactable/D1")?.gameObject },
            {"E1", fixedPianoParent.transform.Find("key115/E1Interactable/E1")?.gameObject },
            {"F1", fixedPianoParent.transform.Find("key115/F1Interactable/F1")?.gameObject },
            {"G1", fixedPianoParent.transform.Find("key115/G1Interactable/G1")?.gameObject },

            {"A2", fixedPianoParent.transform.Find("key115/A2Interactable/A2")?.gameObject },
            {"B2", fixedPianoParent.transform.Find("key115/B2Interactable/B2")?.gameObject },
            {"C2", fixedPianoParent.transform.Find("key115/C2Interactable/C2")?.gameObject },
            {"D2", fixedPianoParent.transform.Find("key115/D2Interactable/D2")?.gameObject },
            {"E2", fixedPianoParent.transform.Find("key115/E2Interactable/E2")?.gameObject },
            {"F2", fixedPianoParent.transform.Find("key115/F2Interactable/F2")?.gameObject },
            {"G2", fixedPianoParent.transform.Find("key115/G2Interactable/G2")?.gameObject },

            {"A3", fixedPianoParent.transform.Find("key115/A3Interactable/A3")?.gameObject },
            {"B3", fixedPianoParent.transform.Find("key115/B3Interactable/B3")?.gameObject },
            {"C3", fixedPianoParent.transform.Find("key115/C3Interactable/C3")?.gameObject },
            {"D3", fixedPianoParent.transform.Find("key115/D3Interactable/D3")?.gameObject },
            {"E3", fixedPianoParent.transform.Find("key115/E3Interactable/E3")?.gameObject },
            {"F3", fixedPianoParent.transform.Find("key115/F3Interactable/F3")?.gameObject },
            {"G3", fixedPianoParent.transform.Find("key115/G3Interactable/G3")?.gameObject },

            {"A4", fixedPianoParent.transform.Find("key115/A4Interactable/A4")?.gameObject },
            {"B4", fixedPianoParent.transform.Find("key115/B4Interactable/B4")?.gameObject },
            {"C4", fixedPianoParent.transform.Find("key115/C4Interactable/C4")?.gameObject },
            {"D4", fixedPianoParent.transform.Find("key115/D4Interactable/D4")?.gameObject },
            {"E4", fixedPianoParent.transform.Find("key115/E4Interactable/E4")?.gameObject },
            {"F4", fixedPianoParent.transform.Find("key115/F4Interactable/F4")?.gameObject },
            {"G4", fixedPianoParent.transform.Find("key115/G4Interactable/G4")?.gameObject },

            {"A5", fixedPianoParent.transform.Find("key115/A5Interactable/A5")?.gameObject },
            {"B5", fixedPianoParent.transform.Find("key115/B5Interactable/B5")?.gameObject },
            {"C5", fixedPianoParent.transform.Find("key115/C5Interactable/C5")?.gameObject },
            {"D5", fixedPianoParent.transform.Find("key115/D5Interactable/D5")?.gameObject },
            {"E5", fixedPianoParent.transform.Find("key115/E5Interactable/E5")?.gameObject },
            {"F5", fixedPianoParent.transform.Find("key115/F5Interactable/F5")?.gameObject },
            {"G5", fixedPianoParent.transform.Find("key115/G5Interactable/G5")?.gameObject },

            {"A6", fixedPianoParent.transform.Find("key115/A6Interactable/A6")?.gameObject },
            {"B6", fixedPianoParent.transform.Find("key115/B6Interactable/B6")?.gameObject },
            {"C6", fixedPianoParent.transform.Find("key115/C6Interactable/C6")?.gameObject },
            {"D6", fixedPianoParent.transform.Find("key115/D6Interactable/D6")?.gameObject },
            {"E6", fixedPianoParent.transform.Find("key115/E6Interactable/E6")?.gameObject },
            {"F6", fixedPianoParent.transform.Find("key115/F6Interactable/F6")?.gameObject },
            {"G6", fixedPianoParent.transform.Find("key115/G6Interactable/G6")?.gameObject },

            {"A7", fixedPianoParent.transform.Find("key115/A7Interactable/A7")?.gameObject },
            {"B7", fixedPianoParent.transform.Find("key115/B7Interactable/B7")?.gameObject },
            {"C7", fixedPianoParent.transform.Find("key115/C7Interactable/C7")?.gameObject },

            {"Asharp0", fixedPianoParent.transform.Find("key115/Asharp0Interactable/Asharp0")?.gameObject },
            {"Csharp0", fixedPianoParent.transform.Find("key115/Csharp0Interactable/Csharp0")?.gameObject },
            {"Dsharp0", fixedPianoParent.transform.Find("key115/Dsharp0Interactable/Dsharp0")?.gameObject },
            {"Fsharp0", fixedPianoParent.transform.Find("key115/Fsharp0Interactable/Fsharp0")?.gameObject },
            {"Gsharp0", fixedPianoParent.transform.Find("key115/Gsharp0Interactable/Gsharp0")?.gameObject },
            
            {"Asharp1", fixedPianoParent.transform.Find("key115/Asharp1Interactable/Asharp1")?.gameObject },
            {"Csharp1", fixedPianoParent.transform.Find("key115/Csharp1Interactable/Csharp1")?.gameObject },
            {"Dsharp1", fixedPianoParent.transform.Find("key115/Dsharp1Interactable/Dsharp1")?.gameObject },
            {"Fsharp1", fixedPianoParent.transform.Find("key115/Fsharp1Interactable/Fsharp1")?.gameObject },
            {"Gsharp1", fixedPianoParent.transform.Find("key115/Gsharp1Interactable/Gsharp1")?.gameObject },
            
            {"Asharp2", fixedPianoParent.transform.Find("key115/Asharp2Interactable/Asharp2")?.gameObject },
            {"Csharp2", fixedPianoParent.transform.Find("key115/Csharp2Interactable/Csharp2")?.gameObject },
            {"Dsharp2", fixedPianoParent.transform.Find("key115/Dsharp2Interactable/Dsharp2")?.gameObject },
            {"Fsharp2", fixedPianoParent.transform.Find("key115/Fsharp2Interactable/Fsharp2")?.gameObject },
            {"Gsharp2", fixedPianoParent.transform.Find("key115/Gsharp2Interactable/Gsharp2")?.gameObject },
            
            {"Asharp3", fixedPianoParent.transform.Find("key115/Asharp3Interactable/Asharp3")?.gameObject },
            {"Csharp3", fixedPianoParent.transform.Find("key115/Csharp3Interactable/Csharp3")?.gameObject },
            {"Dsharp3", fixedPianoParent.transform.Find("key115/Dsharp3Interactable/Dsharp3")?.gameObject },
            {"Fsharp3", fixedPianoParent.transform.Find("key115/Fsharp3Interactable/Fsharp3")?.gameObject },
            {"Gsharp3", fixedPianoParent.transform.Find("key115/Gsharp3Interactable/Gsharp3")?.gameObject },
            
            {"Asharp4", fixedPianoParent.transform.Find("key115/Asharp4Interactable/Asharp4")?.gameObject },
            {"Csharp4", fixedPianoParent.transform.Find("key115/Csharp4Interactable/Csharp4")?.gameObject },
            {"Dsharp4", fixedPianoParent.transform.Find("key115/Dsharp4Interactable/Dsharp4")?.gameObject },
            {"Fsharp4", fixedPianoParent.transform.Find("key115/Fsharp4Interactable/Fsharp4")?.gameObject },
            {"Gsharp4", fixedPianoParent.transform.Find("key115/Gsharp4Interactable/Gsharp4")?.gameObject },
            
            {"Asharp5", fixedPianoParent.transform.Find("key115/Asharp5Interactable/Asharp5")?.gameObject },
            {"Csharp5", fixedPianoParent.transform.Find("key115/Csharp5Interactable/Csharp5")?.gameObject },
            {"Dsharp5", fixedPianoParent.transform.Find("key115/Dsharp5Interactable/Dsharp5")?.gameObject },
            {"Fsharp5", fixedPianoParent.transform.Find("key115/Fsharp5Interactable/Fsharp5")?.gameObject },
            {"Gsharp5", fixedPianoParent.transform.Find("key115/Gsharp5Interactable/Gsharp5")?.gameObject },
            
            {"Asharp6", fixedPianoParent.transform.Find("key115/Asharp6Interactable/Asharp6")?.gameObject },
            {"Csharp6", fixedPianoParent.transform.Find("key115/Csharp6Interactable/Csharp6")?.gameObject },
            {"Dsharp6", fixedPianoParent.transform.Find("key115/Dsharp6Interactable/Dsharp6")?.gameObject },
            {"Fsharp6", fixedPianoParent.transform.Find("key115/Fsharp6Interactable/Fsharp6")?.gameObject },
            {"Gsharp6", fixedPianoParent.transform.Find("key115/Gsharp6Interactable/Gsharp6")?.gameObject },

            {"Asharp7", fixedPianoParent.transform.Find("key115/Asharp7Interactable/Asharp7")?.gameObject },
        };
    }

    public void SelectSong(ISong song)
    {
        currentSong = song;
        Debug.Log($"Selected song: {song.SongName}");
    }

    public void OnFinishButtonClicked()
    {
        if(DropNotes.isOn){
            if (!isPlaying && currentSong != null)
            {
                isPlaying = true;
                combinedQueue = new Queue<Notes>(CombineHands());
                songTimer = 0f;
                PlayNextNotes();
                twinkleManager.report.gameObject.SetActive(false);
                if(currentSong.SongName == "Twinkle Twinkle Little Star"){
                    twinkleManager.ActivateImage1(); 
                    twinkleManager.enabled = true; 
                    twinkleManager.durationTime = 0f;
                    twinkleManager.errorKeys = 0;
                }
                
            }
            else
            {
                Debug.LogWarning("No song selected or playback is already active.");
            }
        }else{
            if (LockNote.isOn && !DropNotes.isOn && AutoScroll.isOn)
            {

                twinkleManager.ActivateImage1(); 
                twinkleManager.enabled = true; 
                twinkleManager.durationTime = 0f; 
                twinkleManager.errorKeys = 0;
            }if (!LockNote.isOn && !DropNotes.isOn && AutoScroll.isOn){
                isPlaying = true;
                combinedQueue = new Queue<Notes>(CombineHands());
                songTimer = 0f;
                PlayNextNotes();
                twinkleManager.ActivateImage1(); 
                twinkleManager.enabled = true; 
                twinkleManager.durationTime = 0f;
                twinkleManager.errorKeys = 0;
            }
            if (LockNote.isOn && !DropNotes.isOn && !AutoScroll.isOn)
            {

                twinkleManager.ActivateImage1(); 
                twinkleManager.enabled = true; 
                twinkleManager.durationTime = 0f; 
                twinkleManager.errorKeys = 0;
            }

        }

    }

    void Update()
    {
        songTimer += Time.deltaTime / speedMultiplier;

        if (isPlaying && currentNote != null)
        {
            if (songTimer >= currentNote.getStartBeat())
            {
                if (LockNote.isOn)
                {
                    if(DropNotes.isOn){
                        if(string.Equals(currentSong.SongName,"Twinkle Twinkle Little Star")){

                        }
                    }else if(AutoScroll.isOn){
                        if(string.Equals(currentSong.SongName,"Twinkle Twinkle Little Star")){

                        }
                    }else{
                        
                    }
                   
                }
                else
                {   
                    if(DropNotes.isOn ){
                        PlayNoteAndHighlight(currentNote);
                    }else if(AutoScroll.isOn ){
                        HighlightKeyOnly(currentNote);
                    }else{

                    }
                }
                    
                PlayNextNotes();
            }

        }

        if (LockNote.isOn)
        {
            //CheckPokeDurations();
        }
    }

    void PlayNextNotes()
    {
        if (combinedQueue.Count > 0)
        {
            currentNote = combinedQueue.Dequeue();
        }
        else
        {
            isPlaying = false;
            Debug.Log("Song playback finished.");
        }
    }

    void PlayNoteAndHighlight(Notes note)
    {
        string keyValue = note.getKeyValue();

        if (pianoKeys.ContainsKey(keyValue))
        {
            GameObject key = pianoKeys[keyValue];
            AudioSource keyAudio = key.GetComponent<AudioSource>();
            MeshRenderer renderer = key.GetComponent<MeshRenderer>();

            keyAudio.Play();
            Material defaultMaterial = renderer.material;
            renderer.material = highlightedMaterial;
            if(string.Equals(keyValue,"C3") && note.getStartBeat() == 57.0f && note.getEndBeat() == 64.0f && currentSong.SongName == "Twinkle Twinkle Little Star"){
                twinkleManager.image1.gameObject.SetActive(false);
                twinkleManager.image2.gameObject.SetActive(true);
            }
            if(string.Equals(keyValue,"D3") && note.getStartBeat() == 121.0f && note.getEndBeat() == 128.0f && currentSong.SongName == "Twinkle Twinkle Little Star"){
                twinkleManager.image2.gameObject.SetActive(false);
                twinkleManager.image3.gameObject.SetActive(true);
            }
            if(string.Equals(keyValue,"C3") && note.getStartBeat() == 185.0f && note.getEndBeat() == 192.0f && currentSong.SongName == "Twinkle Twinkle Little Star"){
                twinkleManager.image3.gameObject.SetActive(false);
                twinkleManager.DisplayReport();
            }
            StartCoroutine(RestoreMaterialAfterDelay(renderer, defaultMaterial, (note.getEndBeat() - note.getStartBeat()) * speedMultiplier));
        }
    }

    void HighlightKeyOnly(Notes note)
    {
         string keyValue = note.getKeyValue();

        if (pianoKeys.ContainsKey(keyValue))
        {
            GameObject key = pianoKeys[keyValue];
            AudioSource keyAudio = key.GetComponent<AudioSource>();
            MeshRenderer renderer = key.GetComponent<MeshRenderer>();

            //keyAudio.Play();
            Material defaultMaterial = renderer.material;
            renderer.material = highlightedMaterial;
            if(string.Equals(keyValue,"C3") && note.getStartBeat() == 57.0f && note.getEndBeat() == 64.0f && currentSong.SongName == "Twinkle Twinkle Little Star"){
                twinkleManager.image1.gameObject.SetActive(false);
                twinkleManager.image2.gameObject.SetActive(true);
            }
            if(string.Equals(keyValue,"D3") && note.getStartBeat() == 121.0f && note.getEndBeat() == 128.0f && currentSong.SongName == "Twinkle Twinkle Little Star"){
                twinkleManager.image2.gameObject.SetActive(false);
                twinkleManager.image3.gameObject.SetActive(true);
            }
            if(string.Equals(keyValue,"C3") && note.getStartBeat() == 185.0f && note.getEndBeat() == 192.0f && currentSong.SongName == "Twinkle Twinkle Little Star"){
                twinkleManager.image3.gameObject.SetActive(false);
                twinkleManager.DisplayReport();
            }
            StartCoroutine(RestoreMaterialAfterDelay(renderer, defaultMaterial, (note.getEndBeat() - note.getStartBeat()) * speedMultiplier));
        }
    }

    IEnumerator RestoreMaterialAfterDelay(MeshRenderer renderer, Material defaultMaterial, float delay)
    {
        yield return new WaitForSeconds(delay);
        renderer.material = defaultMaterial;
    }

    void ResetAllKeyMaterials()
    {
        foreach (var key in pianoKeys.Values)
        {
            MeshRenderer renderer = key.GetComponent<MeshRenderer>();
            renderer.material = highlightedMaterial; // Reset to default
        }
    }

    void CheckPokeDurations()
    {
        foreach (var kvp in pianoKeys)
        {
            string key = kvp.Key;
            GameObject keyObject = kvp.Value;

            if (keyObject != null)
            {
                KeyIsPoked keyIsPoked = keyObject.GetComponent<KeyIsPoked>();

                if (keyIsPoked != null && keyIsPoked.GetIsPoked())
                {
                   
                    keyPokedDuration[key] += Time.deltaTime;

                   
                    if (keyPokedDuration[key] >= (currentNote.getEndBeat() - currentNote.getStartBeat()) * speedMultiplier)
                    {
                        ResetKeyMaterial(key);
                        keyPokedStatus[key] = false;
                        keyPokedDuration[key] = 0f; 
                    }
                }
                else
                {
                
                    keyPokedDuration[key] = 0f;
                }
            }
        }
    }

    void ResetKeyMaterial(string key)
    {
        if (pianoKeys.ContainsKey(key))
        {
            GameObject keyObject = pianoKeys[key];
            MeshRenderer renderer = keyObject.GetComponent<MeshRenderer>();

            
            renderer.material = highlightedMaterial; 
        }
    }

    List<Notes> CombineHands()
    {
        List<Notes> allNotes = new List<Notes>(currentSong.getRightHand());
        allNotes.AddRange(currentSong.getLeftHand());
        allNotes.Sort((a, b) => a.getStartBeat().CompareTo(b.getStartBeat()));
        return allNotes;
    }
}
