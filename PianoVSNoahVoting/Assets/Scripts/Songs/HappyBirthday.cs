using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyBirthday : Songholder
{
    public HappyBirthday()
    {
        SetBPM(110);
        SetSongName("Happy Birthday");
        SetMaxBeat(312);
        songNotes = new List<NoteClass>();
        SetDifficulty(2);
        songNotes.Add(new NoteClass(31, 0, 6, 1));
        songNotes.Add(new NoteClass(31, 8, 12, 1));
        songNotes.Add(new NoteClass(33, 14, 22, 1));
        songNotes.Add(new NoteClass(31, 24, 32, 1));
        songNotes.Add(new NoteClass(36, 34, 42, 1));
        songNotes.Add(new NoteClass(35, 44, 60, 1));
        songNotes.Add(new NoteClass(31, 62, 68, 1));
        songNotes.Add(new NoteClass(31, 70, 74, 1));
        songNotes.Add(new NoteClass(33, 76, 84, 1));
        songNotes.Add(new NoteClass(31, 86, 94, 1));
        songNotes.Add(new NoteClass(38, 96, 104, 1));
        songNotes.Add(new NoteClass(36, 106, 122, 1));

        songNotes.Add(new NoteClass(31, 124, 130, 1));
        songNotes.Add(new NoteClass(31, 132, 138, 1));
        songNotes.Add(new NoteClass(43, 140, 148, 1));
        songNotes.Add(new NoteClass(40, 150, 158, 1));
        songNotes.Add(new NoteClass(36, 160, 166, 1));
        songNotes.Add(new NoteClass(36, 168, 172, 1));
        songNotes.Add(new NoteClass(35, 174, 182, 1));
        songNotes.Add(new NoteClass(33, 184, 192, 1));
        songNotes.Add(new NoteClass(41, 194, 200, 1));
        songNotes.Add(new NoteClass(41, 202, 206, 1));
        songNotes.Add(new NoteClass(40, 208, 216, 1));
        songNotes.Add(new NoteClass(36, 218, 226, 1));
        songNotes.Add(new NoteClass(38, 228, 236, 1));
        songNotes.Add(new NoteClass(36, 238, 254, 1));
    }
}
