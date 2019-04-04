using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowYourBoat : Songholder
{
    public RowYourBoat()
    {
        SetBPM(100);
        SetSongName("Row Row Row Your Boat");

        songNotes = new List<NoteClass>();

        songNotes.Add(new NoteClass(26, 0, 8, 1));
        songNotes.Add(new NoteClass(26, 10, 18, 1));
        songNotes.Add(new NoteClass(26, 20, 26, 1));
        songNotes.Add(new NoteClass(28, 28, 32, 1));
        songNotes.Add(new NoteClass(30, 32, 40, 1));
        songNotes.Add(new NoteClass(30, 42, 50, 1));
        songNotes.Add(new NoteClass(28, 52, 56, 1));
        songNotes.Add(new NoteClass(30, 56, 64, 1));
        songNotes.Add(new NoteClass(31, 66, 70, 1));
        songNotes.Add(new NoteClass(33, 70, 78, 1));

        songNotes.Add(new NoteClass(38, 82, 86, 1));
        songNotes.Add(new NoteClass(38, 86, 90, 1));
        songNotes.Add(new NoteClass(38, 88, 92, 1));

        songNotes.Add(new NoteClass(33, 94, 98, 1));
        songNotes.Add(new NoteClass(33, 98, 102, 1));
        songNotes.Add(new NoteClass(33, 102, 106, 1));
    }
}
