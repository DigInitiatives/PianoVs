using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Songholder : MonoBehaviour
{
	public List<NoteClass> songNotes;
    public int bpm, timeSignature, beat;
    public string songName;

	protected int c1 = 0,
				cSharp1 = 1,
				d1 = 2,
				dSharp1 = 3,
				e1 = 4,
				f1 = 5,
				fSharp1 = 6,
				g1 = 7,
				gSharp1 = 8,
				a1 = 9,
				aSharp1 = 10,
				b1 = 11,

				c2 = 12,
				cSharp2 = 13,
				d2 = 14,
				dSharp2 = 15,
				e2 = 16,
				f2 = 17,
				fSharp2 = 18,
				g2 = 19,
				gSharp2 = 20,
				a2 = 21,
				aSharp2 = 22,
				b2 = 23,

				c3 = 24,
				cSharp3 = 25,
				d3 = 26,
				dSharp3 = 27,
				e3 = 28,
				f3 = 29,
				fSharp3 = 30,
				g3 = 31,
				gSharp3 = 32,
				a3 = 33,
				aSharp3 = 34,
				b3 = 35,

				c4 = 36,
				cSharp4 = 37,
				d4 = 38,
				dSharp4 = 39,
				e4 = 40,
				f4 = 41,
				fSharp4 = 42,
				g4 = 43,
				gSharp4 = 44,
				a4 = 45,
				aSharp4 = 46,
				b4 = 47,
				c5 = 48;

    public void SetBPM(int newBpm)
    {
        bpm = newBpm;
    }
    public int GetBPM()
    {
        return bpm;
    }


    public void SetTimeSignature(int newTimeSignature)
    {
        timeSignature = newTimeSignature;
    }
    public int GetTimeSignature()
    {
        return timeSignature;
    }


    public void SetMaxBeat(int newBeat)
    {
        beat = newBeat;
    }
    public int GetMaxBeat()
    {
        return beat;
    }


    public void SetSongName(string newName)
    {
        songName = newName;
    }
    public string GetSongName()
    {
        return songName;
    }
    public void SetSong()
    {
        songNotes = SongRecording.recordednotes;
    }
}
