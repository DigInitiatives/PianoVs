using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisThemeA : Songholder
{
    public TetrisThemeA()
    {
        SetBPM(120);
        SetSongName("Tetris Theme A");

        songNotes = new List<NoteClass>();
        songNotes.Add(new NoteClass(40, 0, 14, 1));
        songNotes.Add(new NoteClass(35, 14, 22, 1));
        songNotes.Add(new NoteClass(36, 22, 30, 1));
        songNotes.Add(new NoteClass(38, 30, 44, 1));
        songNotes.Add(new NoteClass(36, 44, 52, 1));
        songNotes.Add(new NoteClass(35, 52, 60, 1));
        songNotes.Add(new NoteClass(33, 60, 74, 1));
        songNotes.Add(new NoteClass(33, 74, 82, 1));
        songNotes.Add(new NoteClass(36, 82, 90, 1));
        songNotes.Add(new NoteClass(40, 90, 104, 1));
        songNotes.Add(new NoteClass(38, 104, 112, 1));
        songNotes.Add(new NoteClass(36, 112, 120, 1));
        songNotes.Add(new NoteClass(35, 120, 134, 1));
        songNotes.Add(new NoteClass(35, 134, 142, 1));
        songNotes.Add(new NoteClass(36, 142, 150, 1));
        songNotes.Add(new NoteClass(38, 150, 164, 1));
        songNotes.Add(new NoteClass(40, 164, 178, 1));
        songNotes.Add(new NoteClass(36, 178, 192, 1));
        songNotes.Add(new NoteClass(33, 192, 204, 1));
        songNotes.Add(new NoteClass(33, 204, 220, 1));

        //second measure
        songNotes.Add(new NoteClass(38, 236, 250, 1));
        songNotes.Add(new NoteClass(41, 250, 258, 1));
        songNotes.Add(new NoteClass(45, 258, 272, 1));
        songNotes.Add(new NoteClass(43, 272, 280, 1));
        songNotes.Add(new NoteClass(41, 280, 288, 1));
        songNotes.Add(new NoteClass(40, 288, 302, 1));
        songNotes.Add(new NoteClass(36, 302, 310, 1));
        songNotes.Add(new NoteClass(40, 310, 324, 1));
        songNotes.Add(new NoteClass(38, 324, 332, 1));
        songNotes.Add(new NoteClass(36, 332, 340, 1));
        songNotes.Add(new NoteClass(35, 340, 354, 1));
        songNotes.Add(new NoteClass(35, 354, 362, 1));
        songNotes.Add(new NoteClass(36, 362, 370,1));
        songNotes.Add(new NoteClass(38, 370, 384, 1));
        songNotes.Add(new NoteClass(40, 384, 398, 1));
        songNotes.Add(new NoteClass(36, 398, 412, 1));
        songNotes.Add(new NoteClass(33, 412, 426, 1));
        songNotes.Add(new NoteClass(33, 426, 442, 1));

        //third measure
        songNotes.Add(new NoteClass(40, 456, 488, 1));
        songNotes.Add(new NoteClass(36, 488, 520, 1));
        songNotes.Add(new NoteClass(38, 520, 552, 1));
        songNotes.Add(new NoteClass(35, 552, 582, 1));
        songNotes.Add(new NoteClass(36, 582, 614, 1));
        songNotes.Add(new NoteClass(33, 614, 646, 1));
        songNotes.Add(new NoteClass(31, 646, 678, 1));
        songNotes.Add(new NoteClass(35, 678, 710, 1));

        songNotes.Add(new NoteClass(40, 456 + 254, 488 + 254, 1));
        songNotes.Add(new NoteClass(36, 488 + 254, 520 + 254, 1));
        songNotes.Add(new NoteClass(38, 520 + 254, 552 + 254, 1));
        songNotes.Add(new NoteClass(35, 552 + 254, 582 + 254, 1));
        songNotes.Add(new NoteClass(36, 582 + 254, 852, 1));
        songNotes.Add(new NoteClass(40, 852, 866, 1));
        songNotes.Add(new NoteClass(45, 866, 898, 1));
        songNotes.Add(new NoteClass(43, 898, 930, 1));
    }
}
