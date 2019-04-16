using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABC : Songholder
{
    public ABC()
    {
        songNotes = new List<NoteClass>();
        SetSongName("ABC");
        SetBPM(120);
        SetMaxBeat(1000);
        SetTimeSignature(4);

        songNotes = new List<NoteClass>();
        songNotes.Add(new NoteClass(28, 0, 16, 1)); //A
        songNotes.Add(new NoteClass(28, 18, 34, 1)); //B
        songNotes.Add(new NoteClass(35, 36, 52, 1)); //C
        songNotes.Add(new NoteClass(35, 54, 70, 1)); //D
        songNotes.Add(new NoteClass(37, 72, 86, 1)); //E
        songNotes.Add(new NoteClass(37, 88, 104, 1)); //F
        songNotes.Add(new NoteClass(35, 106, 138, 1)); //G

        songNotes.Add(new NoteClass(33, 140, 156, 1)); //H
        songNotes.Add(new NoteClass(33, 158, 174, 1));//I
        songNotes.Add(new NoteClass(32, 176, 192, 1)); //J
        songNotes.Add(new NoteClass(32, 194, 210, 1)); //K
        songNotes.Add(new NoteClass(30, 212, 228, 1));//L
        songNotes.Add(new NoteClass(30, 230, 246, 1));//MNO
        songNotes.Add(new NoteClass(28, 248, 280, 1)); //P

        songNotes.Add(new NoteClass(35, 282, 298, 1));//Q
        songNotes.Add(new NoteClass(35, 300, 316, 1));//R
        songNotes.Add(new NoteClass(33, 318, 350, 1)); //S

        songNotes.Add(new NoteClass(32, 352, 368, 1)); //T 
        songNotes.Add(new NoteClass(32, 370, 386, 1)); //U
        songNotes.Add(new NoteClass(30, 388, 420, 1)); //V

        songNotes.Add(new NoteClass(35, 422, 454, 1)); //W
        songNotes.Add(new NoteClass(33, 456, 488, 1)); //X

        songNotes.Add(new NoteClass(32, 490, 506, 1)); //Y
        songNotes.Add(new NoteClass(32, 508, 524, 1)); //Y
        songNotes.Add(new NoteClass(30, 526, 558, 1)); //Z


        songNotes.Add(new NoteClass(28, 0 + 558, 16 + 558, 1));
        songNotes.Add(new NoteClass(28, 18 + 558, 34 + 558, 1));
        songNotes.Add(new NoteClass(35, 36 + 558, 52 + 558, 1));
        songNotes.Add(new NoteClass(35, 54 + 558, 70 + 558, 1));
        songNotes.Add(new NoteClass(37, 72 + 558, 86 + 558, 1));
        songNotes.Add(new NoteClass(37, 88 + 558, 104 + 558, 1));
        songNotes.Add(new NoteClass(35, 106 + 558, 122 + 558, 1));
        songNotes.Add(new NoteClass(33, 132 + 558, 148 + 558, 1));
        songNotes.Add(new NoteClass(33, 150 + 558, 166 + 558, 1));
        songNotes.Add(new NoteClass(32, 168 + 558, 184 + 558, 1));
        songNotes.Add(new NoteClass(32, 186 + 558, 202 + 558, 1));
        songNotes.Add(new NoteClass(30, 204 + 558, 220 + 558, 1));
        songNotes.Add(new NoteClass(30, 222 + 558, 238 + 558, 1));
        songNotes.Add(new NoteClass(28, 240 + 558, 256 + 558, 1));
    }
}
