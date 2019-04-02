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
		int barTime = timeSignature * 16;

		rightBarCount = 0;

		//Right Hand

		// Bar 1
		songNotes = new List<NoteClass>();
		songNotes.Add(new NoteClass(d4, 0, 32, 1));

		songNotes.Add(new NoteClass(aSharp3, 0, 32, 1));

		songNotes.Add(new NoteClass(f4, 32, 56, 1));

		songNotes.Add(new NoteClass(c4, 32, 56, 1));

		songNotes.Add(new NoteClass(f4, 56, 64, 1));


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

	}
}
