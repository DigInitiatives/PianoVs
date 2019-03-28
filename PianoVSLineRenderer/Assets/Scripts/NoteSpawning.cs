///Author: Austin Bentley
///This script is designed to spawn the notes according to the song chosen
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 19-Mar-2019
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawning : MonoBehaviour
{
    //Will call from reasource folder eventually
    GameObject note, heldNote, blackNote, heldBlackNote, noteBar;

    public List<GameObject> keyBoardKeys;

    public GameObject endHeldNote;

    //The Songs Beats Per Minute
    public float bpm, timesignature, beatTime, timestamp;
    public int beat;
    public List<Songholder> songs;
    List<int> heldNoteCount;
    List<Vector3> holdNotes;
    int songSelect = 4;
    List<GameObject> whiteNotes, blackNotes, whiteNotesHeld, blackNotesHeld;

    int whiteNoteCounter = 3, blackNoteCounter = 3, whiteHeldNoteCounter = 3, blackHeldNoteCounter = 3;

    // Start is called before the first frame update
    void Start()
    {
        note = Resources.Load("Prefabs/WhiteNote") as GameObject;
        heldNote = Resources.Load("Prefabs/WhiteNoteHeld") as GameObject;
        blackNote = Resources.Load("Prefabs/BlackNote") as GameObject;
        heldBlackNote = Resources.Load("Prefabs/BlackNoteHeld") as GameObject;
        noteBar = Resources.Load("Prefabs/NoteBar") as GameObject;

        whiteNotes = new List<GameObject>();
        blackNotes = new List<GameObject>();
        whiteNotesHeld = new List<GameObject>();
        blackNotesHeld = new List<GameObject>();

        //Grabs all children of the object (the Keyspawners on the Keyboard)
        keyBoardKeys = new List<GameObject>();
        holdNotes = new List<Vector3>();
        heldNoteCount = new List<int>();
        for (int c = 0; c < transform.childCount; c++)
        {
            keyBoardKeys.Add(transform.GetChild(c).gameObject);
        }
        songs = new List<Songholder>();

        songs.Add(new ATHousandMiles());
        songs.Add(new HotCrossBuns());
        songs.Add(new SongOfStorms());
        songs.Add(new LostWoods());
        songs.Add(new PerfectAdvanced());

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
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (beat == songs[songSelect].GetMaxBeat())
        {
            beat = 0;
        }

        //Debug.Log(keyBoardKeys.Count);
        #region Instatiate New Notes and Starts or Stops held notes
        //calculates the current beat number based on BPM and tracks beats
        if (Time.time - beatTime > timestamp || beat == 0)
        {
            if (beat % 64 == 0 || beat == 0)
            {
                Instantiate(noteBar, transform.position, transform.rotation);
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
                                    blackNotes[blackNoteCounter].GetComponent<LineRenderer>().enabled = true;
                                    blackNotes[blackNoteCounter].GetComponent<LineRenderer>().SetPosition(0, Vector3.zero);
                                    blackNotes[blackNoteCounter].GetComponent<LineRenderer>().SetPosition(1, new Vector3(0, 50, 0));

                                    holdNotes.Add(new Vector3(c, blackNoteCounter, notes.GetEnd()));
                                }
                                blackNoteCounter++;
                                if (blackNoteCounter >= blackNotes.Count)
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
                                    whiteNotes[whiteNoteCounter].GetComponent<LineRenderer>().enabled = true;
                                    whiteNotes[whiteNoteCounter].GetComponent<LineRenderer>().SetPosition(0, Vector3.zero);
                                    whiteNotes[whiteNoteCounter].GetComponent<LineRenderer>().SetPosition(1, new Vector3(0, 50, 0));

                                    holdNotes.Add(new Vector3(c, whiteNoteCounter, notes.GetEnd()));
                                }
                                whiteNoteCounter++;
                                if (whiteNoteCounter >= whiteNotes.Count)
                                {
                                    whiteNoteCounter = 0;
                                }
                            }

                        }
                    }
                }
            }

            if (holdNotes.Count > 0)
            {
                for (int c = 0; c < holdNotes.Count - 1; c++)
                {
                    if (beat >= holdNotes[c].z)
                    {
                        GameObject endTransform = Instantiate(endHeldNote, keyBoardKeys[Mathf.RoundToInt(holdNotes[c].x)].transform.position, keyBoardKeys[Mathf.RoundToInt(holdNotes[c].x)].transform.rotation);

                        if (holdNotes[c].x == 1 || holdNotes[c].x == 3 || holdNotes[c].x == 6 || holdNotes[c].x == 8 || holdNotes[c].x == 10 || holdNotes[c].x == 13 || holdNotes[c].x == 15 || holdNotes[c].x == 18 || holdNotes[c].x == 20 || holdNotes[c].x == 22
                            || holdNotes[c].x == 25 || holdNotes[c].x == 27 || holdNotes[c].x == 30 || holdNotes[c].x == 32 || holdNotes[c].x == 34 || 37 == holdNotes[c].x || holdNotes[c].x == 39 || holdNotes[c].x == 42 || holdNotes[c].x == 44 || holdNotes[c].x == 46)
                        {
                            blackNotes[Mathf.RoundToInt(holdNotes[c].y)].GetComponent<LineRenderer>().SetPosition(1, new Vector3(0, endTransform.transform.position.y, 0));
                            holdNotes.RemoveAt(c);
                        }
                        else
                        {
                            whiteNotes[Mathf.RoundToInt(holdNotes[c].y)].GetComponent<LineRenderer>().SetPosition(1, new Vector3(0, endTransform.transform.position.y, 0));
                            holdNotes.RemoveAt(c);
                        }
                    }
                }
            }

            beat++;
            timestamp = Time.time;
        }
        #endregion
    }

    public void RecordSong()
    {
        songs[songs.Count - 1].SetSong();
        songSelect = songs.Count - 1;
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
            holdNotes.Clear();
        }
    }
}
