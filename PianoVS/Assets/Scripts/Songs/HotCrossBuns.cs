using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Austin Bentley
 * Last Edited on : January 31st 2019
 * This script is designed to hold the notes for the Song hotcross buns
**/
public class HotCrossBuns : Songholder
{
    public HotCrossBuns()
    {
		bpm = 120;

		songNotes = new List<NoteClass>();
		songNotes.Add(new NoteClass(28, 0 * 16, 0 * 16, 1));
		songNotes.Add(new NoteClass(26, 2 * 16, 2 * 16, 1));
		songNotes.Add(new NoteClass(24, 4 * 16, 7 * 16, 1));
		songNotes.Add(new NoteClass(28, 8 * 16, 8 * 16, 1));
		songNotes.Add(new NoteClass(26, 10 * 16, 10 * 16, 1));
		songNotes.Add(new NoteClass(24, 12 * 16, 15 * 16, 1));
		songNotes.Add(new NoteClass(24, 16 * 16, 16 * 16, 1));
		songNotes.Add(new NoteClass(24, 17 * 16, 17 * 16, 1));
		songNotes.Add(new NoteClass(24, 18 * 16, 18 * 16, 1));
		songNotes.Add(new NoteClass(24, 19 * 16, 19 * 16, 1));
		songNotes.Add(new NoteClass(26, 20 * 16, 20 * 16, 1));
		songNotes.Add(new NoteClass(26, 21 * 16, 21 * 16, 1));
		songNotes.Add(new NoteClass(26, 22 * 16, 22 * 16, 1));
		songNotes.Add(new NoteClass(26, 23 * 16, 23 * 16, 1));
		songNotes.Add(new NoteClass(28, 24 * 16, 24 * 16, 1));
		songNotes.Add(new NoteClass(26, 26 * 16, 26 * 16, 1));
		songNotes.Add(new NoteClass(24, 28 * 16, 31 * 16, 1));
	}
}
