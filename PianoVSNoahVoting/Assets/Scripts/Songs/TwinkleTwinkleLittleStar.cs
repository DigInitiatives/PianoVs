using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinkleTwinkleLittleStar : Songholder
{
    public TwinkleTwinkleLittleStar()
    {
        SetBPM(120);
        SetSongName("Twinkle Twinkle Little Star");
        SetMaxBeat(1000);
        songNotes = new List<NoteClass>();
        songNotes.Add(new NoteClass(28, 0, 16, 1));
        songNotes.Add(new NoteClass(28, 18, 34, 1));
        songNotes.Add(new NoteClass(35, 36, 52, 1));
        songNotes.Add(new NoteClass(35, 54, 70, 1));
        songNotes.Add(new NoteClass(37, 72, 86, 1));
        songNotes.Add(new NoteClass(37, 88, 104, 1));
        songNotes.Add(new NoteClass(35, 106, 122,1));
        songNotes.Add(new NoteClass(33, 132, 148, 1));
        songNotes.Add(new NoteClass(33, 150, 166, 1));
        songNotes.Add(new NoteClass(32, 168, 184, 1));
        songNotes.Add(new NoteClass(32, 186, 202, 1));
        songNotes.Add(new NoteClass(30, 204, 220, 1));
        songNotes.Add(new NoteClass(30, 222, 238, 1));
        songNotes.Add(new NoteClass(28, 240, 256, 1));
        songNotes.Add(new NoteClass(35, 266, 282, 1));
        songNotes.Add(new NoteClass(35, 284, 300, 1));
        songNotes.Add(new NoteClass(33, 302, 318, 1));
        songNotes.Add(new NoteClass(33, 320, 336, 1));
        songNotes.Add(new NoteClass(32, 338, 354, 1));
        songNotes.Add(new NoteClass(32, 356, 372, 1));
        songNotes.Add(new NoteClass(30, 374, 390, 1));
        songNotes.Add(new NoteClass(35, 400, 416, 1));
        songNotes.Add(new NoteClass(35, 418, 434, 1));
        songNotes.Add(new NoteClass(33, 436, 452, 1));
        songNotes.Add(new NoteClass(33, 454, 470, 1));
        songNotes.Add(new NoteClass(32, 472, 488, 1));
        songNotes.Add(new NoteClass(32, 490, 506, 1));
        songNotes.Add(new NoteClass(30, 508, 524, 1));

        songNotes.Add(new NoteClass(28, 0 + 534, 16 + 534, 1));
        songNotes.Add(new NoteClass(28, 18 + 534, 34 + 534, 1));
        songNotes.Add(new NoteClass(35, 36 + 534, 52 + 534, 1));
        songNotes.Add(new NoteClass(35, 54 + 534, 70 + 534, 1));
        songNotes.Add(new NoteClass(37, 72 + 534, 86 + 534, 1));
        songNotes.Add(new NoteClass(37, 88 + 534, 104 + 534, 1));
        songNotes.Add(new NoteClass(35, 106 + 534, 122 + 534, 1));
        songNotes.Add(new NoteClass(33, 132 + 534, 148 + 534, 1));
        songNotes.Add(new NoteClass(33, 150 + 534, 166 + 534, 1));
        songNotes.Add(new NoteClass(32, 168 + 534, 184 + 534, 1));
        songNotes.Add(new NoteClass(32, 186 + 534, 202 + 534, 1));
        songNotes.Add(new NoteClass(30, 204 + 534, 220 + 534, 1));
        songNotes.Add(new NoteClass(30, 222 + 534, 238 + 534, 1));
        songNotes.Add(new NoteClass(28, 240 + 534, 256 + 534, 1));
    }
}
