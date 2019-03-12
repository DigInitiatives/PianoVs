using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Austin Bentley
 * Last Edited on : Febuary 12th 2019
 * This script is designed to spawn the notes according to the song chosen
 * ChangeLog: Added Improved held note funtionallity to accomadate the score function
**/
public class NoteSpawning : MonoBehaviour
{
    //Will call from reasource folder eventually

    [SerializeField]
    GameObject note, heldNote, blackNote, heldBlackNote, noteBar;

    public List<GameObject> keyBoardKeys;

    //The Songs Beats Per Minute
    public float bpm, timesignature, beatTime, timestamp;
    public int beat;
    public List<Songholder> songs;
    List<int> holdNotes, heldNoteCount;
    int songSelect = 3;
    List<GameObject> whiteNotes, blackNotes, whiteNotesHeld, blackNotesHeld;

    int whiteNoteCounter = 3, blackNoteCounter = 3, whiteHeldNoteCounter = 3, blackHeldNoteCounter = 3;

    // Start is called before the first frame update
    void Start()
    {
        whiteNotes = new List<GameObject>();
        blackNotes = new List<GameObject>();
        whiteNotesHeld = new List<GameObject>();
        blackNotesHeld = new List<GameObject>();

        //Grabs all children of the object (the Keyspawners on the Keyboard)
        keyBoardKeys = new List<GameObject>();
        holdNotes = new List<int>();
        heldNoteCount = new List<int>();
        for (int c = 0; c < transform.childCount; c++)
        {
            keyBoardKeys.Add(transform.GetChild(c).gameObject);
            holdNotes.Add(0);
            heldNoteCount.Add(-15);
        }
        songs = new List<Songholder>();

        songs.Add(new ATHousandMiles());
        songs.Add(new HotCrossBuns());
        songs.Add(new SongOfStorms());
        songs.Add(new LostWoods());


        songs.Add(new RecordedSong());
        beat = 0;
        timestamp = Time.time;
        bpm = songs[songSelect].GetBPM();
        timesignature = songs[songSelect].GetTimeSignature();
        beatTime = (60 / bpm) / 16f;

        for (int c = 0; c < 500; c++)
        {
            whiteNotes.Add(Instantiate(note, new Vector3(-1000, -1000, -1000), transform.rotation));
            blackNotes.Add(Instantiate(blackNote, new Vector3(-1000, -1000, -1000), transform.rotation));
            whiteNotesHeld.Add(Instantiate(heldNote, new Vector3(-1000, -1000, -1000), transform.rotation));
            blackNotesHeld.Add(Instantiate(heldBlackNote, new Vector3(-1000, -1000, -1000), transform.rotation));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (beat == songs[songSelect].GetMaxBeat())
        {
            beat = 0;
        }

        if (beat % 64 == 0 || beat == 0)
        {
            Instantiate(noteBar, transform.position, transform.rotation);
        }
        //Debug.Log(keyBoardKeys.Count);
        #region Instatiate New Notes and Starts or Stops held notes
        //calculates the current beat number based on BPM and tracks beats
        if (Time.time - beatTime > timestamp || beat == 0)
        {
            //Resets the held notes if the current beat is their end beat
            for (int c = 0; c <= holdNotes.Count - 1; c++)
            {
                if (holdNotes[c] == beat)
                {
                    holdNotes[c] = 0;
                }
            }

            //instantiates the note if it starts on this beat
            foreach (NoteClass notes in songs[songSelect].songNotes)
            {
                if (notes.GetStart() == beat)
                {
                    for (int c = 0; c < keyBoardKeys.Count; c++)
                    {
                        if (c == 1 || c == 3 || c == 6 || c == 8 || c == 10 || c == 13 || c == 15 || c == 18 || c == 20 || c == 22
                            || c == 25 || c == 27 || c == 30 || c == 32 || c == 34 || 37 == c || c == 39 || c == 42 || c == 44 || c == 46)
                        {
                            if (notes.GetKey() == c)
                            {
                                blackNotes[blackNoteCounter].transform.position = keyBoardKeys[c].transform.position;
                                blackNotes[blackNoteCounter].transform.gameObject.SetActive(true);
                                if (notes.GetEnd() != notes.GetStart())
                                {
                                    holdNotes[c] = notes.GetEnd();
                                    heldNoteCount[c] = -15;
                                }
                                blackNoteCounter++;
                                if (blackNoteCounter > blackNotes.Count)
                                {
                                    blackNoteCounter = 0;
                                }
                            }
                        }
                        else
                        {
                            if (notes.GetKey() == c)
                            {
                                whiteNotes[whiteNoteCounter].transform.position = keyBoardKeys[c].transform.position;
                                whiteNotes[whiteNoteCounter].transform.gameObject.SetActive(true);
                                if (notes.GetEnd() != notes.GetStart())
                                {
                                    holdNotes[c] = notes.GetEnd();
                                    heldNoteCount[c] = -15;
                                }
                                whiteNoteCounter++;
                                if (whiteNoteCounter > whiteNotes.Count)
                                {
                                    whiteNoteCounter = 0;
                                }
                            }

                        }
                    }
                }
            }

            beat++;
            timestamp = Time.time;
        }
        #endregion
        #region Held NoteCreation
        // Checks to see if the note is being held. If it is, then create a held note.
        for (int c = 0; c <= holdNotes.Count - 1; c++)
        {
            if (c == 1 || c == 3 || c == 6 || c == 8 || c == 10 || c == 13 || c == 15 || c == 18 || c == 20 || c == 22
                || c == 25 || c == 27 || c == 30 || c == 32 || c == 34 || 37 == c || c == 39 || c == 42 || c == 44 || c == 46)
            {
                if (holdNotes[c] != 0)
                {
                    blackNotesHeld[blackHeldNoteCounter].transform.position = keyBoardKeys[c].transform.position;
                    blackNotesHeld[blackHeldNoteCounter].transform.gameObject.SetActive(true);
                    blackNotesHeld[blackHeldNoteCounter].gameObject.GetComponent<SpriteRenderer>().sortingOrder = heldNoteCount[c];
                    heldNoteCount[c]++;
                    blackHeldNoteCounter++;
                    if (blackHeldNoteCounter >= blackNotesHeld.Count)
                    {
                        blackHeldNoteCounter = 0;
                    }
                }
            }
            else
            {
                if (holdNotes[c] != 0)
                {
                    whiteNotesHeld[whiteHeldNoteCounter].transform.position = keyBoardKeys[c].transform.position;
                    whiteNotesHeld[whiteHeldNoteCounter].transform.gameObject.SetActive(true);
                    whiteNotesHeld[whiteHeldNoteCounter].gameObject.GetComponent<SpriteRenderer>().sortingOrder = heldNoteCount[c];
                    heldNoteCount[c]++;
                    whiteHeldNoteCounter++;
                    if (whiteHeldNoteCounter >= whiteNotesHeld.Count)
                    {
                        whiteHeldNoteCounter = 0;
                    }
                }
            }
        }
        #endregion
    }

    public void RecordSong()
    {
        songs[0].SetSong();
        songSelect = 0;
        beat = 0;
        timestamp = Time.time;
        bpm = songs[songSelect].GetBPM();
        timesignature = songs[songSelect].GetTimeSignature();
        beatTime = (60 / bpm) / 16f;
    }


    public void PlayNewSong(int songID)
    {
        songSelect = songID;
        beat = 0;
        timestamp = Time.time;
        bpm = songs[songSelect].GetBPM();
        timesignature = songs[songSelect].GetTimeSignature();
        beatTime = (60 / bpm) / 16f;
        beat = Mathf.RoundToInt(timesignature) * 16 * -1;
    }


    public void ResetHoldNotes()
    {
        for (int c = 0; c <= holdNotes.Count - 1; c++)
        {
            holdNotes[c] = 0;
        }
    }
}
