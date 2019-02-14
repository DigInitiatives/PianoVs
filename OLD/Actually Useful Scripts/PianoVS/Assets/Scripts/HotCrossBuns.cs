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
		songNotes.Add(new NoteClass(4, 1, 1, 1));
		songNotes.Add(new NoteClass(2, 3, 3, 1));
		songNotes.Add(new NoteClass(0, 5, 8, 1));
		songNotes.Add(new NoteClass(4, 9, 9, 1));
		songNotes.Add(new NoteClass(2, 11, 11, 1));
		songNotes.Add(new NoteClass(0, 13, 16, 1));
		songNotes.Add(new NoteClass(0, 17, 17, 1));
		songNotes.Add(new NoteClass(0, 18, 18, 1));
		songNotes.Add(new NoteClass(0, 19, 19, 1));
		songNotes.Add(new NoteClass(0, 20, 20, 1));
		songNotes.Add(new NoteClass(2, 21, 21, 1));
		songNotes.Add(new NoteClass(2, 22, 22, 1));
		songNotes.Add(new NoteClass(2, 23, 23, 1));
		songNotes.Add(new NoteClass(2, 24, 24, 1));
		songNotes.Add(new NoteClass(4, 25, 25, 1));
		songNotes.Add(new NoteClass(2, 27, 27, 1));
		songNotes.Add(new NoteClass(0, 29, 32, 1));
	}
}
