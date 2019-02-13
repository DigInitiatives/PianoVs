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

		songNotes.Add(new NoteClass(42, 0 + 256, 4 + 256, 1));
		songNotes.Add(new NoteClass(42, 4 + 256, 8 + 256, 1));
		songNotes.Add(new NoteClass(42, 8 + 256, 12 + 256, 1));
		songNotes.Add(new NoteClass(42, 12 + 256, 16 + 256, 1));
		songNotes.Add(new NoteClass(37, 20 + 256, 32 + 256, 1));
		songNotes.Add(new NoteClass(37, 32 + 256, 48 + 256, 1));
		songNotes.Add(new NoteClass(39, 48 + 256, 52 + 256, 1));
		songNotes.Add(new NoteClass(37, 52 + 256, 56 + 256, 1));
		songNotes.Add(new NoteClass(37, 56 + 256, 76 + 64, 1));

		songNotes.Add(new NoteClass(37, 0 + 320, 12 + 320, 1));
		songNotes.Add(new NoteClass(39, 12 + 320, 20 + 320, 1));
		songNotes.Add(new NoteClass(37, 20 + 320, 28 + 320, 1));
		songNotes.Add(new NoteClass(37, 28 + 320, 36 + 320, 1));
		songNotes.Add(new NoteClass(38, 36 + 320, 40 + 320, 1));
		songNotes.Add(new NoteClass(35, 40 + 320, 44 + 320, 1));
		songNotes.Add(new NoteClass(39, 44 + 320, 52 + 320, 1));
		songNotes.Add(new NoteClass(35, 52 + 320, 64 + 320, 1));



		songNotes.Add(new NoteClass(47, 0 + 384, 4 + 384, 1));
		songNotes.Add(new NoteClass(35, 4 + 384, 8 + 384, 1));
		songNotes.Add(new NoteClass(47, 8 + 384, 12 + 384, 1));
		songNotes.Add(new NoteClass(45, 12 + 384, 16 + 384, 1));
		songNotes.Add(new NoteClass(35, 16 + 384, 20 + 384, 1));
		songNotes.Add(new NoteClass(45, 20 + 384, 24 + 384, 1));
		songNotes.Add(new NoteClass(42, 24 + 384, 28 + 384, 1));
		songNotes.Add(new NoteClass(35, 28 + 384, 32 + 384, 1));
		songNotes.Add(new NoteClass(42, 32 + 384, 36 + 384, 1));
		songNotes.Add(new NoteClass(35, 36 + 384, 40 + 384, 1));
		songNotes.Add(new NoteClass(42, 40 + 384, 44 + 384, 1));
		songNotes.Add(new NoteClass(35, 44 + 384, 48 + 384, 1));
		songNotes.Add(new NoteClass(39, 48 + 384, 52 + 384, 1));
		songNotes.Add(new NoteClass(40, 52 + 384, 56 + 384, 1));
		songNotes.Add(new NoteClass(39, 56 + 384, 60 + 384, 1));
		songNotes.Add(new NoteClass(35, 60 + 384, 64 + 384, 1));

		songNotes.Add(new NoteClass(47, 0 + 448, 4 + 448, 1));
		songNotes.Add(new NoteClass(35, 4 + 448, 8 + 448, 1));
		songNotes.Add(new NoteClass(47, 8 + 448, 12 + 448, 1));
		songNotes.Add(new NoteClass(45, 12 + 448, 16 + 448, 1));
		songNotes.Add(new NoteClass(35, 16 + 448, 20 + 448, 1));
		songNotes.Add(new NoteClass(45, 20 + 448, 24 + 448, 1));
		songNotes.Add(new NoteClass(42, 24 + 448, 28 + 448, 1));
		songNotes.Add(new NoteClass(35, 28 + 448, 32 + 448, 1));
		songNotes.Add(new NoteClass(42, 32 + 448, 36 + 448, 1));
		songNotes.Add(new NoteClass(35, 36 + 448, 40 + 448, 1));
		songNotes.Add(new NoteClass(42, 40 + 448, 44 + 448, 1));
		songNotes.Add(new NoteClass(35, 44 + 448, 48 + 448, 1));
		songNotes.Add(new NoteClass(39, 48 + 448, 52 + 448, 1));
		songNotes.Add(new NoteClass(40, 52 + 448, 56 + 448, 1));
		songNotes.Add(new NoteClass(39, 56 + 448, 60 + 448, 1));
		songNotes.Add(new NoteClass(35, 60 + 448, 64 + 448, 1));



		//Left Hand
		songNotes.Add(new NoteClass(28, 0, 12, 2));
		songNotes.Add(new NoteClass(30, 12, 28, 2));
		songNotes.Add(new NoteClass(27, 28, 48, 2));
		songNotes.Add(new NoteClass(28, 48, 64, 2));

		songNotes.Add(new NoteClass(28, 0 + 64, 12 + 64, 2));
		songNotes.Add(new NoteClass(30, 12 + 64, 28 + 64, 2));
		songNotes.Add(new NoteClass(27, 28 + 64, 64 + 64, 2));


		songNotes.Add(new NoteClass(28, 0 + 128, 12 + 128, 2));
		songNotes.Add(new NoteClass(30, 12 + 128, 28 + 128, 2));
		songNotes.Add(new NoteClass(27, 28 + 128, 48 + 128, 2));
		songNotes.Add(new NoteClass(28, 48 + 128, 64 + 128, 2));

		songNotes.Add(new NoteClass(28, 0 + 192, 12 + 192, 2));
		songNotes.Add(new NoteClass(30, 12 + 192, 24 + 192, 2));
		songNotes.Add(new NoteClass(27, 24 + 192, 48 + 192, 2));
		songNotes.Add(new NoteClass(28, 48 + 192, 64 + 192, 2));

		songNotes.Add(new NoteClass(23, 0 + 256, 12 + 256, 2));
		songNotes.Add(new NoteClass(16, 0 + 256, 12 + 256, 2));
		songNotes.Add(new NoteClass(24, 12 + 256, 16 + 256, 2));
		songNotes.Add(new NoteClass(17, 12 + 256, 16 + 256, 2));
		songNotes.Add(new NoteClass(23, 32 + 256, 48 + 256, 2));
		songNotes.Add(new NoteClass(14, 32 + 256, 48 + 256, 2));
		songNotes.Add(new NoteClass(23, 48 + 256, 56 + 256, 2));
		songNotes.Add(new NoteClass(16, 48 + 256, 56 + 256, 2));

		songNotes.Add(new NoteClass(23, 0 + 320, 12 + 320, 2));
		songNotes.Add(new NoteClass(16, 0 + 320, 12 + 320, 2));
		songNotes.Add(new NoteClass(24, 12 + 320, 16 + 320, 2));
		songNotes.Add(new NoteClass(17, 12 + 320, 16 + 320, 2));
		songNotes.Add(new NoteClass(23, 32 + 320, 48 + 320, 2));
		songNotes.Add(new NoteClass(14, 32 + 320, 48 + 320, 2));
		songNotes.Add(new NoteClass(23, 48 + 320, 56 + 320, 2));
		songNotes.Add(new NoteClass(16, 48 + 320, 56 + 320, 2));

		songNotes.Add(new NoteClass(16, 0 + 384, 12 + 384, 2));
		songNotes.Add(new NoteClass(18, 12 + 384, 28 + 384, 2));
		songNotes.Add(new NoteClass(15, 28 + 384, 64 + 384, 2));

		songNotes.Add(new NoteClass(16, 0 + 448, 12 + 448, 2));
		songNotes.Add(new NoteClass(18, 12 + 448, 28 + 448, 2));
		songNotes.Add(new NoteClass(15, 28 + 448, 64 + 448, 2));
	}
}
