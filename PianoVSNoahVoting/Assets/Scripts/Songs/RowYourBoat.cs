using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowYourBoat : Songholder
{
    public RowYourBoat()
    {
        SetBPM(100);
        SetSongName("Row Row Row Your Boat");
        SetMaxBeat(212);
        SetDifficulty(1);
        songNotes = new List<NoteClass>();

        songNotes.Add(new NoteClass(26, 0, 8, 1));
        songNotes.Add(new NoteClass(26, 10, 18, 1));
        songNotes.Add(new NoteClass(26, 20, 26, 1));
        songNotes.Add(new NoteClass(28, 28, 32, 1));
        songNotes.Add(new NoteClass(30, 32, 40, 1));
        songNotes.Add(new NoteClass(30, 42, 48, 1));
        songNotes.Add(new NoteClass(28, 48, 52, 1));
        songNotes.Add(new NoteClass(30, 52, 60, 1));
        songNotes.Add(new NoteClass(31, 60, 64, 1));
        songNotes.Add(new NoteClass(33, 64, 72, 1));

        songNotes.Add(new NoteClass(38, 78, 82, 1));
        songNotes.Add(new NoteClass(38, 82, 86, 1));
        songNotes.Add(new NoteClass(38, 86, 90, 1));

        songNotes.Add(new NoteClass(33, 90, 94, 1));
        songNotes.Add(new NoteClass(33, 94, 98, 1));
        songNotes.Add(new NoteClass(33, 98, 102, 1));

        songNotes.Add(new NoteClass(30, 102, 106, 1));
        songNotes.Add(new NoteClass(30, 106, 110, 1));
        songNotes.Add(new NoteClass(30, 110, 114, 1));

        songNotes.Add(new NoteClass(26, 114, 118, 1));
        songNotes.Add(new NoteClass(26, 118, 122, 1));
        songNotes.Add(new NoteClass(26, 122, 126, 1));

        songNotes.Add(new NoteClass(33, 128, 136, 1));
        songNotes.Add(new NoteClass(31, 136, 140, 1));
        songNotes.Add(new NoteClass(30, 140, 148, 1));
        songNotes.Add(new NoteClass(28, 148, 152, 1));
        songNotes.Add(new NoteClass(26, 152, 158, 1));
    }
}
