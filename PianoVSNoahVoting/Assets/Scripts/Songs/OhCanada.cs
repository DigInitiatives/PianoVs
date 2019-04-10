using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhCanada : Songholder
{
	int rightBarCount;
	public OhCanada()
	{
		SetBPM(120);
		SetTimeSignature(4);
		SetMaxBeat(28*64);
        SetSongName("Oh Canada");
		int barTime = timeSignature * 16;
        SetDifficulty(4);
        rightBarCount = 0;

		//Right Hand

		// Bar 1
		songNotes = new List<NoteClass>();
		songNotes.Add(new NoteClass(d4, 0, 32, 1));

		songNotes.Add(new NoteClass(aSharp3, 0, 32, 1));

		songNotes.Add(new NoteClass(f4, 32, 56, 1));

		songNotes.Add(new NoteClass(c4, 32, 56, 1));

		songNotes.Add(new NoteClass(f4, 56, 64, 1));

		rightBarCount++;

		// Bar 2
		songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;


		// Bar 3
		songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(aSharp3, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(dSharp4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(f4, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(g4, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 4
		songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 5
		songNotes.Add(new NoteClass(d4, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(e4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(dSharp4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 6
		songNotes.Add(new NoteClass(f4, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(a3, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(g4, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 7
		songNotes.Add(new NoteClass(a4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(a4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(g4, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(g4, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 8
		songNotes.Add(new NoteClass(f4, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(a3, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;


		// Bar 9
		songNotes.Add(new NoteClass(dSharp4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(dSharp4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;



		// Bar 10
		songNotes.Add(new NoteClass(f4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(dSharp4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(dSharp4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(f4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 11
		songNotes.Add(new NoteClass(g4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(f4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(dSharp4, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 12
		songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;


		// Bar 13
		songNotes.Add(new NoteClass(dSharp4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(dSharp4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 14
		songNotes.Add(new NoteClass(f4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(dSharp4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 15
		songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(f4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(f4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
		songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(dSharp4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
		songNotes.Add(new NoteClass(aSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));
		songNotes.Add(new NoteClass(aSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(dSharp4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));
		songNotes.Add(new NoteClass(aSharp3, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 16
		songNotes.Add(new NoteClass(f4, 0 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(a3, 0 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 17
		songNotes.Add(new NoteClass(d4, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(f4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(f4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 18
		songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 19
		songNotes.Add(new NoteClass(d4, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(f4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(f4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 20
		songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 21
		songNotes.Add(new NoteClass(f4, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(g4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(g4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 22
		songNotes.Add(new NoteClass(g4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(dSharp4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 23
		songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;

		// Bar 24
		songNotes.Add(new NoteClass(d4, 0 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;


		// Bar 25
		songNotes.Add(new NoteClass(f4, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
		songNotes.Add(new NoteClass(d4, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(b4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));
		songNotes.Add(new NoteClass(d4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(b4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;


		// Bar 26
		songNotes.Add(new NoteClass(g4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(f4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(dSharp4, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(d4, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;


		// Bar 27
		songNotes.Add(new NoteClass(d4, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		songNotes.Add(new NoteClass(a3, 32 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

		rightBarCount++;


		// Bar 28
		songNotes.Add(new NoteClass(b3, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

		rightBarCount++;


	}
}
