using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdeToJoy : Songholder
{
    public OdeToJoy()
    {
        SetBPM(100);
        SetSongName("Ode To Joy");
        SetMaxBeat(700);
        songNotes = new List<NoteClass>();
        SetDifficulty(1);

        songNotes.Add(new NoteClass(28, 0, 8, 1));
        songNotes.Add(new NoteClass(28, 10, 18, 1));
        songNotes.Add(new NoteClass(29, 20, 28, 1));
        songNotes.Add(new NoteClass(31, 30, 38, 1));
        songNotes.Add(new NoteClass(31, 40, 48, 1));
        songNotes.Add(new NoteClass(29, 50, 58, 1));
        songNotes.Add(new NoteClass(28, 60, 68, 1));
        songNotes.Add(new NoteClass(26, 70, 78, 1));
        songNotes.Add(new NoteClass(24, 80, 88, 1));
        songNotes.Add(new NoteClass(24, 90, 98, 1));
        songNotes.Add(new NoteClass(26, 100, 108, 1));
        songNotes.Add(new NoteClass(28, 110, 118, 1));
        songNotes.Add(new NoteClass(28, 120, 128, 1));
        songNotes.Add(new NoteClass(26, 130, 134, 1));
        songNotes.Add(new NoteClass(26, 136, 150, 1));

        songNotes.Add(new NoteClass(28, 152, 160, 1));
        songNotes.Add(new NoteClass(28, 162, 170, 1));
        songNotes.Add(new NoteClass(29, 172, 180, 1));
        songNotes.Add(new NoteClass(31, 182, 190, 1));
        songNotes.Add(new NoteClass(31, 192, 200, 1));
        songNotes.Add(new NoteClass(29, 202, 210, 1));
        songNotes.Add(new NoteClass(28, 212, 220, 1));
        songNotes.Add(new NoteClass(26, 222, 230, 1));
        songNotes.Add(new NoteClass(24, 232, 240, 1));
        songNotes.Add(new NoteClass(24, 242, 250, 1));
        songNotes.Add(new NoteClass(26, 252, 260, 1));
        songNotes.Add(new NoteClass(28, 262, 270, 1));
        songNotes.Add(new NoteClass(26, 272, 280, 1));
        songNotes.Add(new NoteClass(24, 282, 286, 1));
        songNotes.Add(new NoteClass(24, 288, 302, 1));

        songNotes.Add(new NoteClass(26, 304, 312, 1));
        songNotes.Add(new NoteClass(26, 314, 322, 1));
        songNotes.Add(new NoteClass(28, 324, 332, 1));
        songNotes.Add(new NoteClass(24, 334, 342, 1));
        songNotes.Add(new NoteClass(26, 344, 352, 1));
        songNotes.Add(new NoteClass(28, 354, 358, 1));
        songNotes.Add(new NoteClass(29, 358, 362, 1));
        songNotes.Add(new NoteClass(28, 364, 372, 1));
        songNotes.Add(new NoteClass(24, 374, 382, 1));
        songNotes.Add(new NoteClass(26, 384, 392, 1));
        songNotes.Add(new NoteClass(28, 394, 398, 1));
        songNotes.Add(new NoteClass(29, 398, 402, 1));
        songNotes.Add(new NoteClass(28, 404, 412, 1));
        songNotes.Add(new NoteClass(26, 414, 422, 1));
        songNotes.Add(new NoteClass(24, 424, 432, 1));
        songNotes.Add(new NoteClass(26, 434, 442, 1));
        songNotes.Add(new NoteClass(19, 444, 452, 1));

        songNotes.Add(new NoteClass(28, 0 + 454, 8 + 454, 1));
        songNotes.Add(new NoteClass(28, 10 + 454, 18 + 454, 1));
        songNotes.Add(new NoteClass(29, 20 + 454, 28 + 454, 1));
        songNotes.Add(new NoteClass(31, 30 + 454, 38 + 454, 1));
        songNotes.Add(new NoteClass(31, 40 + 454, 48 + 454, 1));
        songNotes.Add(new NoteClass(29, 50 + 454, 58 + 454, 1));
        songNotes.Add(new NoteClass(28, 60 + 454, 68 + 454, 1));
        songNotes.Add(new NoteClass(26, 70 + 454, 78 + 454, 1));
        songNotes.Add(new NoteClass(24, 80 + 454, 88 + 454, 1));
        songNotes.Add(new NoteClass(24, 90 + 454, 98 + 454, 1));
        songNotes.Add(new NoteClass(26, 100 + 454, 108 + 454, 1));
        songNotes.Add(new NoteClass(28, 110 + 454, 118 + 454, 1));
        songNotes.Add(new NoteClass(26, 120 + 454, 128 + 454, 1));
        songNotes.Add(new NoteClass(24, 130 + 454, 134 + 454, 1));
        songNotes.Add(new NoteClass(24, 136 + 454, 150 + 454, 1));
    }
}
