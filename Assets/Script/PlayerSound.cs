using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSound : MonoBehaviour
{
    public Dictionary<string, GameObject> pianoKeys;
    public Material highlightedMaterial;
    public Button finishButton;
    public GameObject fixedPianoParent;
    public float speedMultiplier = 0.5f; // Adjust playback speed

    private ISong currentSong; // Current song selected for playback
    private bool isPlaying = false;
    private Queue<Notes> combinedQueue;
    private Notes currentNote;
    private float songTimer = 0f;

    void Start()
    {
        InitializePianoKeys();

        if (finishButton != null)
        {
            finishButton.onClick.AddListener(OnFinishButtonClicked);
        }
        else
        {
            Debug.LogError("Finish Button not assigned in the Inspector.");
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
            {"E1", fixedPianoParent.transform.Find("key115/E0Interactable/E1")?.gameObject },
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

            {"Fsharp3", fixedPianoParent.transform.Find("key115/Fsharp3Interactable/Fsharp3")?.gameObject },



        };
    }

    public void SelectSong(ISong song)
    {
        currentSong = song;
        Debug.Log($"Selected song: {song.SongName}");
    }

    public void OnFinishButtonClicked()
    {
        if (!isPlaying && currentSong != null)
        {
            isPlaying = true;
            combinedQueue = new Queue<Notes>(CombineHands());
            songTimer = 0f;
            PlayNextNotes();
        }
        else
        {
            Debug.LogWarning("No song selected or playback is already active.");
        }
    }

    void Update()
    {
        if (isPlaying && currentNote != null)
        {
            songTimer += Time.deltaTime / speedMultiplier;

            if (songTimer >= currentNote.getStartBeat())
            {
                PlayNoteAndHighlight(currentNote);
                PlayNextNotes();
            }
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

            StartCoroutine(RestoreMaterialAfterDelay(renderer, defaultMaterial, (note.getEndBeat() - note.getStartBeat()) * speedMultiplier));
        }
    }

    IEnumerator RestoreMaterialAfterDelay(MeshRenderer renderer, Material defaultMaterial, float delay)
    {
        yield return new WaitForSeconds(delay);
        renderer.material = defaultMaterial;
    }

    List<Notes> CombineHands()
    {
        List<Notes> allNotes = new List<Notes>(currentSong.getRightHand());
        allNotes.AddRange(currentSong.getLeftHand());
        allNotes.Sort((a, b) => a.getStartBeat().CompareTo(b.getStartBeat()));
        return allNotes;
    }
}
