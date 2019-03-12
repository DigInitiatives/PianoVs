using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouGotAFriendInMe : Songholder
{
	public YouGotAFriendInMe()
	{
		songNotes = new List<NoteClass>();
		SetBPM(200);
		SetTimeSignature(4);
		SetMaxBeat(640);
		int barTime = timeSignature * 16;
		songNotes = new List<NoteClass>();

		//Right Hand

		//Bar 1

		songNotes.Add(new NoteClass(g3, 8, 16, 1));
		songNotes.Add(new NoteClass(cSharp3, 16, 22, 1));
		songNotes.Add(new NoteClass(dSharp4, 22, 28, 1));
		songNotes.Add(new NoteClass(f4, 28, 32, 1));

		songNotes.Add(new NoteClass(fSharp4, 32, 40, 1));
		songNotes.Add(new NoteClass(g4, 40, 56, 1));
		songNotes.Add(new NoteClass(c4, 40, 56, 1));
		songNotes.Add(new NoteClass(dSharp4, 56, 72, 1));
		songNotes.Add(new NoteClass(c4, 56, 72, 1));


		//Left Hand

		songNotes.Add(new NoteClass(e1, 0, 16, 1));
		songNotes.Add(new NoteClass(b1, 16, 32, 1));
		songNotes.Add(new NoteClass(f2, 16, 32, 1));
		songNotes.Add(new NoteClass(d1, 32, 48, 1));
		songNotes.Add(new NoteClass(f2, 48, 64, 1));
		songNotes.Add(new NoteClass(b2, 48, 64, 1));


	}
}
