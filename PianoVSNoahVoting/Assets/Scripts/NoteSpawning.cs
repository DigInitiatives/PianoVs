﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Austin Bentley
 * Last Edited on : March 7th 2019
 * This script is designed to spawn the notes according to the song chosen
 * ChangeLog: Added ChangeSong method
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
    int songSelect = 8;
	List<int> holdNotes, heldNoteCount;

	// Start is called before the first frame update
	void Start()
    {
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

		songs.Add(new HotCrossBuns());
		songs.Add(new ATHousandMiles());
        songs.Add(new SongOfStorms());
        songs.Add(new LostWoods());
        songs.Add(new TwinkleTwinkleLittleStar());
        songs.Add(new TetrisThemeA());
        songs.Add(new JingleBells());
        songs.Add(new OdeToJoy());
        songs.Add(new HappyBirthday());

		beat = 0;
		timestamp = Time.time;
        bpm = songs[songSelect].GetBPM();
		timesignature = songs[songSelect].GetTimeSignature();
        beatTime = (60 / bpm) / 16f;
    }

    // Update is called once per frame
    void Update()
	{
        if (beat == songs[songSelect].GetMaxBeat())
        {
            beat = 0;
        }
        if (beat % (timesignature * 16) == 0 || beat == 0)
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
					for(int c = 0; c < keyBoardKeys.Count; c++)
					{
						if(c == 1 || c == 3 || c == 6 || c== 8 || c==10 || c== 13|| c == 15 || c == 18 || c== 20|| c == 22 
							|| c == 25 || c == 27 || c == 30 || c == 32 || c == 34 || 37 == c|| c == 39 || c == 42 || c== 44 || c == 46)
						{
							if (notes.GetKey() == c)
							{
								GameObject instantiatedObject = Instantiate(blackNote, keyBoardKeys[c].transform.position, keyBoardKeys[c].transform.rotation);
								if(notes.GetHand() == 2)
								{
									instantiatedObject.GetComponent<SpriteRenderer>().color = new Color(138, 185, 255);
								}
								if (notes.GetEnd() != notes.GetStart())
								{
									holdNotes[c] = notes.GetEnd();
									heldNoteCount[c] = -15;
								}
							}
						}
						else
						{
							if (notes.GetKey() == c)
							{
								GameObject instantiatedObject = Instantiate(note, keyBoardKeys[c].transform.position, keyBoardKeys[c].transform.rotation);
								if (notes.GetHand() == 2)
								{
									instantiatedObject.GetComponent<SpriteRenderer>().color = new Color(69, 169, 207);
								}
								if (notes.GetEnd() != notes.GetStart())
								{
									holdNotes[c] = notes.GetEnd();
									heldNoteCount[c] = -15;
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
        //Checks to see if the note is being held. If it is, then create a held note.

        for (int c = 0; c <= holdNotes.Count - 1; c++)
        {
            if (c == 1 || c == 3 || c == 6 || c == 8 || c == 10 || c == 13 || c == 15 || c == 18 || c == 20 || c == 22
                || c == 25 || c == 27 || c == 30 || c == 32 || c == 34 || 37 == c || c == 39 || c == 42 || c == 44 || c == 46)
            {
                if (holdNotes[c] != 0)
                {
                    GameObject instantiatedObject = Instantiate(heldBlackNote, keyBoardKeys[c].transform.position, keyBoardKeys[c].transform.rotation);
                    instantiatedObject.gameObject.GetComponent<SpriteRenderer>().sortingOrder = heldNoteCount[c];
                    heldNoteCount[c]++;
                }
            }
            else
            {
                if (holdNotes[c] != 0)
                {
                    GameObject instantiatedObject = Instantiate(heldNote, keyBoardKeys[c].transform.position, keyBoardKeys[c].transform.rotation);
                    instantiatedObject.gameObject.GetComponent<SpriteRenderer>().sortingOrder = heldNoteCount[c];
                    heldNoteCount[c]++;
                }
            }
        }
        #endregion
    }

    public void ChangeSong(int newSongID)
    {
        Debug.Log("Song ID = " + newSongID);
        songSelect = newSongID;
        Debug.Log("Song Select " + songSelect);
        beat = 0;
        bpm = songs[songSelect].GetBPM();
        timesignature = songs[songSelect].GetTimeSignature();
        beatTime = (60 / bpm) / 16f;
    }


    public void ResetHoldNotes()
    {
        for (int c = 0; c <= holdNotes.Count - 1; c++)
        {
            holdNotes[c] = 0;
        }
    }
}
