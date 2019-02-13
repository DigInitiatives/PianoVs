using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Austin Bentley
 * Last Edited on : January 31st 2019
 * This script is designed to hold the notes for the Song hotcross buns
**/
public class ATHousandMiles : Songholder
{
	public ATHousandMiles()
	{
		bpm = 120;

		//Right Hand
		songNotes = new List<NoteClass>();
		songNotes.Add(new NoteClass(47, 0, 4, 1));
		songNotes.Add(new NoteClass(35, 4, 8, 1));
		songNotes.Add(new NoteClass(47, 8, 12, 1));
		songNotes.Add(new NoteClass(45, 12, 16, 1));
		songNotes.Add(new NoteClass(35, 16, 20, 1));
		songNotes.Add(new NoteClass(45, 20, 28, 1));
		songNotes.Add(new NoteClass(42, 28, 48, 1));
		songNotes.Add(new NoteClass(40, 48, 56, 1));
		songNotes.Add(new NoteClass(38, 56, 60, 1));
		songNotes.Add(new NoteClass(35, 60, 64, 1));

		songNotes.Add(new NoteClass(47, 0 + 64, 4 + 64, 1));
		songNotes.Add(new NoteClass(35, 4 + 64, 8 + 64, 1));
		songNotes.Add(new NoteClass(47, 8 + 64, 12 + 64, 1));
		songNotes.Add(new NoteClass(45, 12 + 64, 16 + 64, 1));

		songNotes.Add(new NoteClass(35, 16 + 64, 20 + 64, 1));
		songNotes.Add(new NoteClass(45, 20 + 64, 24 + 64, 1));
		songNotes.Add(new NoteClass(42, 24 + 64, 28 + 64, 1));
		songNotes.Add(new NoteClass(35, 28 + 64, 32 + 64, 1));

		songNotes.Add(new NoteClass(42, 32 + 64, 36 + 64, 1));
		songNotes.Add(new NoteClass(35, 36 + 64, 40 + 64, 1));
		songNotes.Add(new NoteClass(42, 40 + 64, 44 + 64, 1));
		songNotes.Add(new NoteClass(35, 44 + 64, 48 + 64, 1));

		songNotes.Add(new NoteClass(39, 48 + 64, 52 + 64, 1));
		songNotes.Add(new NoteClass(40, 52 + 64, 56 + 64, 1));
		songNotes.Add(new NoteClass(39, 56 + 64, 60 + 64, 1));
		songNotes.Add(new NoteClass(35, 60 + 64, 64 + 64, 1));

		songNotes.Add(new NoteClass(47, 0 + 128, 4 + 128, 1));
		songNotes.Add(new NoteClass(35, 4 + 128, 8 + 128, 1));
		songNotes.Add(new NoteClass(47, 8 + 128, 12 + 128, 1));
		songNotes.Add(new NoteClass(45, 12 + 128, 16 + 128, 1));
		songNotes.Add(new NoteClass(35, 16 + 128, 20 + 128, 1));
		songNotes.Add(new NoteClass(45, 20 + 128, 28 + 128, 1));
		songNotes.Add(new NoteClass(42, 28 + 128, 48 + 128, 1));
		songNotes.Add(new NoteClass(40, 48 + 128, 56 + 128, 1));
		songNotes.Add(new NoteClass(38, 56 + 128, 60 + 128, 1));
		songNotes.Add(new NoteClass(35, 60 + 128, 64 + 128, 1));

		songNotes.Add(new NoteClass(39, 0 + 192, 4 + 192, 1));
		songNotes.Add(new NoteClass(37, 4 + 192, 8 + 192, 1));
		songNotes.Add(new NoteClass(34, 8 + 192, 12 + 192, 1));
		songNotes.Add(new NoteClass(39, 12 + 192, 16 + 192, 1));
		songNotes.Add(new NoteClass(37, 16 + 192, 20 + 192, 1));
		songNotes.Add(new NoteClass(34, 20 + 192, 24 + 192, 1));
		songNotes.Add(new NoteClass(42, 24 + 192, 48 + 192, 1));
		songNotes.Add(new NoteClass(37, 48 + 192, 64 + 192, 1));



		//Left Hand
		songNotes.Add(new NoteClass(28, 0, 12, 2));
		songNotes.Add(new NoteClass(30, 12, 28, 2));
		songNotes.Add(new NoteClass(27, 28, 48, 2));
		songNotes.Add(new NoteClass(28, 48, 64, 2));

		songNotes.Add(new NoteClass(28, 0 + 64, 12 + 64, 1));
		songNotes.Add(new NoteClass(30, 12 + 64, 28 + 64, 1));
		songNotes.Add(new NoteClass(27, 28 + 64, 64 + 64, 1));


		songNotes.Add(new NoteClass(28, 0 + 128, 12 + 128, 2));
		songNotes.Add(new NoteClass(30, 12 + 128, 28 + 128, 2));
		songNotes.Add(new NoteClass(27, 28 + 128, 48 + 128, 2));
		songNotes.Add(new NoteClass(28, 48 + 128, 64 + 128, 2));

		songNotes.Add(new NoteClass(28, 0 + 192, 12 + 192, 2));
		songNotes.Add(new NoteClass(30, 12 + 192, 24 + 192, 2));
		songNotes.Add(new NoteClass(27, 24 + 192, 48 + 192, 2));
		songNotes.Add(new NoteClass(28, 48 + 192, 64 + 192, 2));
	}
}
