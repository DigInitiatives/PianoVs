using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaryHadALittleLamb : Songholder
{
    public MaryHadALittleLamb()
    {
        songNotes = new List<NoteClass>();

        SetTimeSignature(4);
        SetBPM(200);

        songNotes.Add(new NoteClass(40, 0, 16, 1));
        songNotes.Add(new NoteClass(38, 16, 32, 1));
        songNotes.Add(new NoteClass(36, 32, 48, 1));
        songNotes.Add(new NoteClass(38, 48, 64, 1));
        songNotes.Add(new NoteClass(40, 64, 80, 1));
        songNotes.Add(new NoteClass(40, 80, 96, 1));
        songNotes.Add(new NoteClass(40, 96, 112, 1));
        songNotes.Add(new NoteClass(38, 128, 144, 1));
        songNotes.Add(new NoteClass(38, 144, 160, 1));
        songNotes.Add(new NoteClass(38, 160, 176, 1));
        songNotes.Add(new NoteClass(40, 192, 208, 1));
        songNotes.Add(new NoteClass(43, 208, 222, 1));
        songNotes.Add(new NoteClass(43, 222, 238, 1));

        songNotes.Add(new NoteClass(40, 0 + 254, 16 + 254, 1));
        songNotes.Add(new NoteClass(38, 16 + 254, 32 + 254, 1));
        songNotes.Add(new NoteClass(36, 32 + 254, 48 + 254, 1));
        songNotes.Add(new NoteClass(38, 48 + 254, 64 + 254, 1));
        songNotes.Add(new NoteClass(40, 64 + 254, 80 + 254, 1));
        songNotes.Add(new NoteClass(40, 80 + 254, 96 + 254, 1));
        songNotes.Add(new NoteClass(40, 96 + 254, 112 + 254, 1));
        songNotes.Add(new NoteClass(40, 112 + 254, 128 + 254, 1));
        songNotes.Add(new NoteClass(38, 128 + 254, 144 + 254, 1));
        songNotes.Add(new NoteClass(38, 144 + 254, 160 + 254, 1));
        //fix time
        songNotes.Add(new NoteClass(40, 176 + 254, 192 + 254, 1));
        songNotes.Add(new NoteClass(38, 192 + 254, 208 + 254, 1));
        songNotes.Add(new NoteClass(36, 208 + 254, 254 + 254, 1));
    }
}
