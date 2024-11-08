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
            {"C3", fixedPianoParent.transform.Find("key115/C3Interactable/C3")?.gameObject },
            {"D3", fixedPianoParent.transform.Find("key115/D3Interactable/D3")?.gameObject },
            {"E3", fixedPianoParent.transform.Find("key115/E3Interactable/E3")?.gameObject },
            {"G3", fixedPianoParent.transform.Find("key115/G3Interactable/G3")?.gameObject },
            {"A4", fixedPianoParent.transform.Find("key115/A4Interactable/A4")?.gameObject },
            {"F2", fixedPianoParent.transform.Find("key115/F2Interactable/F2")?.gameObject },
            {"F3", fixedPianoParent.transform.Find("key115/F3Interactable/F3")?.gameObject },
            {"G2", fixedPianoParent.transform.Find("key115/G2Interactable/G2")?.gameObject },
            {"A3", fixedPianoParent.transform.Find("key115/A3Interactable/A3")?.gameObject },
            {"B3", fixedPianoParent.transform.Find("key115/B3Interactable/B3")?.gameObject },
            {"E2", fixedPianoParent.transform.Find("key115/E2Interactable/E2")?.gameObject },
            {"D2", fixedPianoParent.transform.Find("key115/D2Interactable/D2")?.gameObject },
            {"C2", fixedPianoParent.transform.Find("key115/C2Interactable/C2")?.gameObject },
            {"B2", fixedPianoParent.transform.Find("key115/B2Interactable/B2")?.gameObject },
            {"G1", fixedPianoParent.transform.Find("key115/G1Interactable/G1")?.gameObject },
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

            // Change the key material to highlighted
            Material defaultMaterial = renderer.material;
            renderer.material = highlightedMaterial;

            // Restore the material after the note's duration
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

        // Sort notes by startBeat to synchronize playback
        allNotes.Sort((a, b) => a.getStartBeat().CompareTo(b.getStartBeat()));
        return allNotes;
    }
}
