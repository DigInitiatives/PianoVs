using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaryHadALittleLamb : Songholder
{
    public MaryHadALittleLamb()
    {
        songNotes = new List<NoteClass>();
        SetSongName("Mary Had A Little Lamb");
        SetBPM(120);
        SetMaxBeat(1000);
        SetTimeSignature(4);
        //SetMaxBeat((timeSignature * 16));
        int barTime = timeSignature * 16;
        int rightBarCount = 0;

        // Bar 1
        songNotes.Add(new NoteClass(e3, 0, 16, 1));
        songNotes.Add(new NoteClass(d3, 16, 32, 1));
        songNotes.Add(new NoteClass(c3, 32, 48, 1));
        songNotes.Add(new NoteClass(d3, 48, 64, 1));

        rightBarCount++;

        // Bar 2
        songNotes.Add(new NoteClass(e3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 32 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 3
        songNotes.Add(new NoteClass(d3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(d3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(d3, 32 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 4

        songNotes.Add(new NoteClass(e3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g3, 32 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 5

        songNotes.Add(new NoteClass(e3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(d3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c3, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(d3, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 6

        songNotes.Add(new NoteClass(e3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 7

        songNotes.Add(new NoteClass(d3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(d3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(d3, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 8

        songNotes.Add(new NoteClass(c3, 0 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));


        rightBarCount++;

    }
}