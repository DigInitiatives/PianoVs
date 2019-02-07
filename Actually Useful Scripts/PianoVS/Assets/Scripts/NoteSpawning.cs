using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Austin Bentley
 * Last Edited on : Febuary 5th 2019
 * This script is designed to spawn the notes according to the song chosen
**/
public class NoteSpawning : MonoBehaviour
{
	[SerializeField]
	GameObject note, heldNote;

	public List<GameObject> keyBoardKeys;

	//The Songs Beats Per Minute
	public float bpm, timesignature, beatTime, timestamp;
	public int beat;
	List<Songholder> songs;
	List<int> holdNotes;

	// Start is called before the first frame update
	void Start()
    {
		//Grabs all children of the object (the Keyspawners on the Keyboard)
		keyBoardKeys = new List<GameObject>();
		holdNotes = new List<int>();
		for (int c = 0; c < transform.childCount; c++)
		{
			keyBoardKeys.Add(transform.GetChild(c).gameObject);
			holdNotes.Add(0);
		}
		songs = new List<Songholder>();
		songs.Add(new HotCrossBuns());
		beat = 0;
		timestamp = Time.time;
		bpm = 120;
		timesignature = 4;
		beatTime = 60 / bpm;
    }

    // Update is called once per frame
    void Update()
    {
		//Debug.Log(keyBoardKeys.Count);
		#region Instatiate New Notes and Starts or Stops held notes
		//calculates the current beat number based on BPM and tracks beats
		if (Time.time - beatTime > timestamp )
		{
			beat++;
			timestamp = Time.time;

			//Resets the held notes if the current beat is their end beat
			for (int c = 0; c <= holdNotes.Count - 1; c++)
			{
				if (holdNotes[c] == beat)
				{
					holdNotes[c] = 0;
				}
			}

			//instantiates the note if it starts on this beat
			foreach (NoteClass notes in songs[0].songNotes)
			{
				if(notes.GetStart() == beat)
				{
					for(int c = 0; c < keyBoardKeys.Count; c++)
					{
						if(notes.GetKey() == c)
						{
							Instantiate(note, keyBoardKeys[c].transform.position, keyBoardKeys[c].transform.rotation);
							if(notes.GetEnd() != notes.GetStart())
							{
								holdNotes[c] = notes.GetEnd();
							}
						}
					}
				}					
			}
		}
		#endregion
		#region Held NoteCreation
		// Checks to see if the note is being held. If it is, then create a held note.
		for (int c =0; c <= holdNotes.Count - 1; c++)
		{
			if(holdNotes[c] != 0)
			{
				Instantiate(heldNote, keyBoardKeys[c].transform.position, keyBoardKeys[c].transform.rotation);
			}
		}
		#endregion
	}
}
