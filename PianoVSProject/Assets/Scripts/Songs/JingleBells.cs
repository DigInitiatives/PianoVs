using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JingleBells : Songholder
{
    public JingleBells()
    {
        SetBPM(120);
        SetMaxBeat(860);
        SetSongName("Jingle Bells");
        SetDifficulty(2);
        songNotes = new List<NoteClass>();
        songNotes.Add(new NoteClass(28, 0, 10, 1));
        songNotes.Add(new NoteClass(28, 12, 22, 1));
        songNotes.Add(new NoteClass(28, 24, 48, 1));

        songNotes.Add(new NoteClass(28, 50, 60, 1));
        songNotes.Add(new NoteClass(28, 62, 72, 1));
        songNotes.Add(new NoteClass(28, 74, 88, 1));

        songNotes.Add(new NoteClass(28, 100, 110, 1));
        songNotes.Add(new NoteClass(31, 112, 122, 1));
        songNotes.Add(new NoteClass(24, 124, 134, 1));
        songNotes.Add(new NoteClass(26, 136, 138, 1));
        songNotes.Add(new NoteClass(28, 142, 174, 1));

        songNotes.Add(new NoteClass(29, 184, 194, 1));
        songNotes.Add(new NoteClass(29, 196, 206, 1));
        songNotes.Add(new NoteClass(29, 208, 218, 1));

        songNotes.Add(new NoteClass(29, 224, 230, 1));
        songNotes.Add(new NoteClass(29, 232, 236, 1));
        songNotes.Add(new NoteClass(28, 240, 250, 1));
        songNotes.Add(new NoteClass(28, 252, 266, 1));

        songNotes.Add(new NoteClass(28, 270, 280, 1));
        songNotes.Add(new NoteClass(26, 282, 292, 1));
        songNotes.Add(new NoteClass(26, 294, 304, 1));
        songNotes.Add(new NoteClass(28, 306, 316, 1));
        songNotes.Add(new NoteClass(26, 318, 334, 1));
        songNotes.Add(new NoteClass(31, 336, 354, 1));

        songNotes.Add(new NoteClass(28, 0 + 360, 10 + 360, 1));
        songNotes.Add(new NoteClass(28, 12 + 360, 22 + 360, 1));
        songNotes.Add(new NoteClass(28, 24 + 360, 48 + 360, 1));

        songNotes.Add(new NoteClass(28, 50 + 360, 60 + 360, 1));
        songNotes.Add(new NoteClass(28, 62 + 360, 72 + 360, 1));
        songNotes.Add(new NoteClass(28, 74 + 360, 88 + 360, 1));

        songNotes.Add(new NoteClass(28, 100 + 360, 110 + 360, 1));
        songNotes.Add(new NoteClass(31, 112 + 360, 122 + 360, 1));
        songNotes.Add(new NoteClass(24, 124 + 360, 134 + 360, 1));
        songNotes.Add(new NoteClass(26, 136 + 360, 138 + 360, 1));
        songNotes.Add(new NoteClass(28, 142 + 360, 174 + 360, 1));

        songNotes.Add(new NoteClass(29, 184 + 360, 194 + 360, 1));
        songNotes.Add(new NoteClass(29, 196 + 360, 206 + 360, 1));
        songNotes.Add(new NoteClass(29, 208 + 360, 218 + 360, 1));

        songNotes.Add(new NoteClass(29, 224 + 360, 230 + 360, 1));
        songNotes.Add(new NoteClass(29, 232 + 360, 236 + 360, 1));
        songNotes.Add(new NoteClass(28, 240 + 360, 250 + 360, 1));
        songNotes.Add(new NoteClass(28, 252 + 360, 266 + 360, 1));

        songNotes.Add(new NoteClass(28, 270 + 360, 280 + 360, 1));
        songNotes.Add(new NoteClass(26, 282 + 360, 292 + 360, 1));
        songNotes.Add(new NoteClass(26, 294 + 360, 304 + 360, 1));
        songNotes.Add(new NoteClass(28, 306 + 360, 316 + 360, 1));
        songNotes.Add(new NoteClass(26, 318 + 360, 334 + 360, 1));
        songNotes.Add(new NoteClass(31, 336 + 360, 354 + 360, 1));
    }
}
