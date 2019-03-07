﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfLaytonTheme : Songholder
{
    public ProfLaytonTheme()
    {
        bpm = 215;

        songNotes = new List<NoteClass>();

        //right hand
        songNotes.Add(new NoteClass(38, 0, 16, 1));
        songNotes.Add(new NoteClass(39, 16, 32, 1));
        songNotes.Add(new NoteClass(41, 32, 48, 1));
        songNotes.Add(new NoteClass(41, 52, 60, 1));
        songNotes.Add(new NoteClass(39, 60, 64, 1));
        songNotes.Add(new NoteClass(38, 64, 68, 1));
        songNotes.Add(new NoteClass(32, 68, 72, 1));
        songNotes.Add(new NoteClass(31, 72, 84, 1));
        songNotes.Add(new NoteClass(30, 84, 88, 1));
        songNotes.Add(new NoteClass(31, 88, 110, 1));
        songNotes.Add(new NoteClass(29, 110, 114, 1));
        songNotes.Add(new NoteClass(31, 114, 134, 1));
        songNotes.Add(new NoteClass(32, 134, 138, 1));
        songNotes.Add(new NoteClass(34, 138, 142, 1));
        songNotes.Add(new NoteClass(c4, 142, 146, 1));
        songNotes.Add(new NoteClass(38, 146, 162, 1));
        songNotes.Add(new NoteClass(39, 162, 178, 1));
        songNotes.Add(new NoteClass(41, 178, 198, 1));
        songNotes.Add(new NoteClass(41, 198, 206, 1));
        songNotes.Add(new NoteClass(39, 206, 210, 1));
        songNotes.Add(new NoteClass(38, 210, 214, 1));
        songNotes.Add(new NoteClass(37, 214, 218, 1));
        songNotes.Add(new NoteClass(36, 218, 234, 1));
        songNotes.Add(new NoteClass(31, 234, 250, 1));
        songNotes.Add(new NoteClass(29, 250, 266, 1));

        //rest for 16 (next note starts at 282)

        songNotes.Add(new NoteClass(38, 282, 290, 1));
        songNotes.Add(new NoteClass(38, 290, 300, 1));
        songNotes.Add(new NoteClass(38, 300, 304, 1));
        songNotes.Add(new NoteClass(39, 304, 308, 1));
        songNotes.Add(new NoteClass(41, 308, 312, 1));
        songNotes.Add(new NoteClass(43, 312, 316, 1));
        songNotes.Add(new NoteClass(41, 316, 320, 1));
        songNotes.Add(new NoteClass(39, 320, 324, 1));
        songNotes.Add(new NoteClass(38, 324, 328, 1));
        songNotes.Add(new NoteClass(38, 328, 332, 1));
        songNotes.Add(new NoteClass(39, 332, 336, 1));
        songNotes.Add(new NoteClass(39, 336, 344, 1));
        songNotes.Add(new NoteClass(39, 344, 348, 1));
        songNotes.Add(new NoteClass(31, 348, 352, 1));
        songNotes.Add(new NoteClass(36, 352, 356, 1));
        songNotes.Add(new NoteClass(38, 356, 360, 1));
        songNotes.Add(new NoteClass(39, 360, 364, 1));
        songNotes.Add(new NoteClass(41, 364, 368, 1));
        songNotes.Add(new NoteClass(39, 368, 372, 1));
        songNotes.Add(new NoteClass(38, 372, 376, 1));
        songNotes.Add(new NoteClass(36, 376, 380, 1));
        songNotes.Add(new NoteClass(31, 380, 390, 1));
        songNotes.Add(new NoteClass(31, 390, 394, 1));
        songNotes.Add(new NoteClass(32, 394, 398, 1));
        songNotes.Add(new NoteClass(34, 398, 402, 1));
        songNotes.Add(new NoteClass(36, 402, 406, 1));
        songNotes.Add(new NoteClass(34, 406, 410, 1));
        songNotes.Add(new NoteClass(32, 410, 414, 1));
        songNotes.Add(new NoteClass(31, 414, 418, 1));
        songNotes.Add(new NoteClass(29, 418, 422, 1));
        songNotes.Add(new NoteClass(34, 422, 426, 1));
        songNotes.Add(new NoteClass(31, 426, 430, 1));
        songNotes.Add(new NoteClass(24, 434, 438, 1));
        songNotes.Add(new NoteClass(26, 438, 442, 1));
        songNotes.Add(new NoteClass(28, 442, 446, 1));
        songNotes.Add(new NoteClass(31, 446, 450, 1));
        songNotes.Add(new NoteClass(36, 450, 454, 1));
        songNotes.Add(new NoteClass(38, 454, 458, 1));

    }
}