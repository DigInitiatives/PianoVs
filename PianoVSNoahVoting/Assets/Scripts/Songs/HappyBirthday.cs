using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyBirthday : Songholder
{
    public HappyBirthday()
    {
        SetBPM(100);
        SetSongName("Happy Birthday");
        songNotes = new List<NoteClass>();

        songNotes.Add(new NoteClass(31, 0, 8, 1));
        songNotes.Add(new NoteClass(31, 8, 12, 1));
        songNotes.Add(new NoteClass(33, 14, 22, 1));
        songNotes.Add(new NoteClass(31, 24, 32, 1));
        songNotes.Add(new NoteClass(36, 34, 42, 1));
        songNotes.Add(new NoteClass(35, 44, 60, 1));
        songNotes.Add(new NoteClass(31, 62, 70, 1));
        songNotes.Add(new NoteClass(31, 70, 74, 1));
        songNotes.Add(new NoteClass(33, 76, 84, 1));
        songNotes.Add(new NoteClass(31, 86, 94, 1));
        songNotes.Add(new NoteClass(38, 96, 104, 1));
        songNotes.Add(new NoteClass(36, 106, 132, 1));


    }
}
