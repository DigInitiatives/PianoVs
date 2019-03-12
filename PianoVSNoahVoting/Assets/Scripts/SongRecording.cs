using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SongRecording
{

	public static List<NoteClass> recordednotes = new List<NoteClass>();
	static float bpm, timesignature, beatTime, timestamp;
	static int beat;
	static bool recording;
	static GameObject[] keysAvalible, spawners;

    // Update is called once per frame
    public static void SongPlaying()
    {
		if ((Time.time - beatTime > timestamp || beat == 0) && recording)
		{
			beat++;
			timestamp = Time.time;
		}
		if(beat == 192)
		{
			keysAvalible = GameObject.FindGameObjectsWithTag("Key");
			foreach(GameObject key in keysAvalible)
			{
				key.GetComponent<IndividualKeyScript>().songrecording = false;
			}
			spawners = GameObject.FindGameObjectsWithTag("Spawner");
			foreach (GameObject spawner in spawners)
			{
				spawner.GetComponent<NoteSpawning>().RecordSong();
			}
		}
		Debug.Log(recordednotes.Count);
	}
	public static void AddNote(int noteAdded)
	{
		if (recording == false)
		{
			recording = true;
			beat = 0;
			timestamp = Time.time;
			bpm = 120;
			timesignature = 4;
			beatTime = (60 / bpm) / 16f;
		}
		recordednotes.Add(new NoteClass(noteAdded, beat, beat, 0));
	}
	public static void StartRecording()
	{
		recording = true;
	}
}
