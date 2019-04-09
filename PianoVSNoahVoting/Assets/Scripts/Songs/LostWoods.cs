using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Josh Sadoway
 * Last Edited on : March 5th 2019
 * This script is designed to hold the notes for the Song Song of Storms
**/
public class LostWoods : Songholder
{
	public LostWoods()
	{
        songNotes = new List<NoteClass>();
        SetBPM(140);
        SetTimeSignature(2);
        SetMaxBeat(1000);
        SetSongName("Lost Woods");
        SetDifficulty(3);
        int barTime = timeSignature * 16;
        int leftBarCount = 0, rightBarCount = 0;

        //Right Hand

        // Bar 1
        songNotes.Add(new NoteClass(f3, 0, 0, 1));
        songNotes.Add(new NoteClass(a3, 8, 8, 1));
        songNotes.Add(new NoteClass(b3, 16, 32, 1));

        rightBarCount++;

        // Bar 2
        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(a3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 3
        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(a3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e4, 24 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        //Left Hand

        // Bar 1
        songNotes.Add(new NoteClass(f2, 0, 0, 2));

        songNotes.Add(new NoteClass(a2, 8, 8, 2));
        songNotes.Add(new NoteClass(c3, 8, 8, 2));

        songNotes.Add(new NoteClass(a2, 16, 16, 2));
        songNotes.Add(new NoteClass(c3, 16, 16, 2));

        songNotes.Add(new NoteClass(a2, 24, 24, 2));
        songNotes.Add(new NoteClass(c3, 24, 24, 2));

        leftBarCount++;

        // Bar 2
        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 3
        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 4
        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;
    }
}
