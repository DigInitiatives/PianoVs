using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Josh Sadoway
 * Last Edited on : February 28th 2019
 * This script is designed to hold the notes for the Song Song of Storms
**/
public class SongOfStorms : Songholder
{
	public SongOfStorms()
	{
        songNotes = new List<NoteClass>();
        SetBPM(200);
        SetTimeSignature(3);
        int barTime = 48;

        //Right Hand

        // Bar 1
        songNotes.Add(new NoteClass(d3, 16, 16, 1));
        songNotes.Add(new NoteClass(f3, 16, 16, 1));
        songNotes.Add(new NoteClass(a3, 16, 16, 1));

        songNotes.Add(new NoteClass(d3, 32, 32, 1));
        songNotes.Add(new NoteClass(f3, 32, 32, 1));
        songNotes.Add(new NoteClass(a3, 32, 32, 1));

        // Bar 2
        songNotes.Add(new NoteClass(e3, 8 + (barTime), 48 + (barTime), 1));
        songNotes.Add(new NoteClass(g3, 16 + (barTime), 48 + (barTime), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime), 48 + (barTime), 1));

        // Bar 3
        songNotes.Add(new NoteClass(f3, 16 + (barTime * 2), 16 + (barTime * 2), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 2), 16 + (barTime * 2), 1));
        songNotes.Add(new NoteClass(c4, 16 + (barTime * 2), 16 + (barTime * 2), 1));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * 2), 32 + (barTime * 2), 1));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 2), 32 + (barTime * 2), 1));
        songNotes.Add(new NoteClass(c4, 32 + (barTime * 2), 32 + (barTime * 2), 1));

        // Bar 4
        songNotes.Add(new NoteClass(e3, 8 + (barTime * 3), 48 + (barTime * 3), 1));
        songNotes.Add(new NoteClass(g3, 16 + (barTime * 3), 48 + (barTime * 3), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 3), 48 + (barTime * 3), 1));

        // Bar 5
        songNotes.Add(new NoteClass(d3, 16 + (barTime * 4), 16 + (barTime * 4), 1));
        songNotes.Add(new NoteClass(f3, 16 + (barTime * 4), 16 + (barTime * 4), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 4), 16 + (barTime * 4), 1));

        songNotes.Add(new NoteClass(d3, 32 + (barTime * 4), 32 + (barTime * 4), 1));
        songNotes.Add(new NoteClass(f3, 32 + (barTime * 4), 32 + (barTime * 4), 1));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 4), 32 + (barTime * 4), 1));

        // Bar 6
        songNotes.Add(new NoteClass(e3, 8 + (barTime * 5), 48 + (barTime * 5), 1));
        songNotes.Add(new NoteClass(g3, 16 + (barTime * 5), 48 + (barTime * 5), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 5), 48 + (barTime * 5), 1));

        // Bar 7
        songNotes.Add(new NoteClass(f3, 16 + (barTime * 6), 16 + (barTime * 6), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 6), 16 + (barTime * 6), 1));
        songNotes.Add(new NoteClass(c4, 16 + (barTime * 6), 16 + (barTime * 6), 1));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * 6), 32 + (barTime * 6), 1));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 6), 32 + (barTime * 6), 1));
        songNotes.Add(new NoteClass(c4, 32 + (barTime * 6), 32 + (barTime * 6), 1));

        // Bar 8
        songNotes.Add(new NoteClass(e3, 8 + (barTime * 7), 48 + (barTime * 7), 1));
        songNotes.Add(new NoteClass(g3, 16 + (barTime * 7), 48 + (barTime * 7), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 7), 48 + (barTime * 7), 1));

        // Bar 9
        songNotes.Add(new NoteClass(d3, 0 + (barTime * 8), 0 + (barTime * 8), 1));
        songNotes.Add(new NoteClass(f3, 8 + (barTime * 8), 8 + (barTime * 8), 1));
        songNotes.Add(new NoteClass(d4, 16 + (barTime * 8), 48 + (barTime * 8), 1));

        // Bar 10
        songNotes.Add(new NoteClass(d3, 0 + (barTime * 9), 0 + (barTime * 9), 1));
        songNotes.Add(new NoteClass(f3, 8 + (barTime * 9), 8 + (barTime * 9), 1));
        songNotes.Add(new NoteClass(d4, 16 + (barTime * 9), 16 + (barTime * 9), 1));

        // Bar 11
        songNotes.Add(new NoteClass(e4, 0 + (barTime * 10), 0 + (barTime * 10), 1));
        songNotes.Add(new NoteClass(f4, 24 + (barTime * 10), 24 + (barTime * 10), 1));
        songNotes.Add(new NoteClass(e4, 32 + (barTime * 10), 32 + (barTime * 10), 1));
        songNotes.Add(new NoteClass(f4, 40 + (barTime * 10), 40 + (barTime * 10), 1));

        // Bar 12
        songNotes.Add(new NoteClass(e4, 0 + (barTime * 11), 0 + (barTime * 11), 1));
        songNotes.Add(new NoteClass(c4, 8 + (barTime * 11), 8 + (barTime * 11), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 11), 48 + (barTime * 11), 1));

        // Bar 13
        songNotes.Add(new NoteClass(a3, 0 + (barTime * 12), 0 + (barTime * 12), 1));
        songNotes.Add(new NoteClass(d3, 16 + (barTime * 12), 16 + (barTime * 12), 1));
        songNotes.Add(new NoteClass(f3, 32 + (barTime * 12), 32 + (barTime * 12), 1));
        songNotes.Add(new NoteClass(g3, 40 + (barTime * 12), 40 + (barTime * 12), 1));

        // Bar 14
        songNotes.Add(new NoteClass(a3, 0 + (barTime * 13), 48 + (barTime * 11), 1));

        // Bar 15
        songNotes.Add(new NoteClass(a3, 0 + (barTime * 14), 0 + (barTime * 14), 1));
        songNotes.Add(new NoteClass(d3, 16 + (barTime * 14), 16 + (barTime * 14), 1));
        songNotes.Add(new NoteClass(f3, 32 + (barTime * 14), 32 + (barTime * 14), 1));
        songNotes.Add(new NoteClass(g3, 40 + (barTime * 14), 40 + (barTime * 14), 1));

        // Bar 16
        songNotes.Add(new NoteClass(e3, 0 + (barTime * 15), 48 + (barTime * 11), 1));

        // Bar 17
        songNotes.Add(new NoteClass(d3, 0 + (barTime * 16), 0 + (barTime * 16), 1));
        songNotes.Add(new NoteClass(f3, 8 + (barTime * 16), 8 + (barTime * 16), 1));
        songNotes.Add(new NoteClass(d4, 16 + (barTime * 16), 48 + (barTime * 16), 1));

        // Bar 18
        songNotes.Add(new NoteClass(d3, 0 + (barTime * 17), 0 + (barTime * 17), 1));
        songNotes.Add(new NoteClass(f3, 8 + (barTime * 17), 8 + (barTime * 17), 1));
        songNotes.Add(new NoteClass(d4, 16 + (barTime * 17), 16 + (barTime * 17), 1));

        // Bar 19
        songNotes.Add(new NoteClass(e4, 0 + (barTime * 18), 0 + (barTime * 18), 1));
        songNotes.Add(new NoteClass(f4, 24 + (barTime * 18), 24 + (barTime * 18), 1));
        songNotes.Add(new NoteClass(e4, 32 + (barTime * 18), 32 + (barTime * 18), 1));
        songNotes.Add(new NoteClass(f4, 40 + (barTime * 18), 40 + (barTime * 18), 1));

        // Bar 20
        songNotes.Add(new NoteClass(e4, 0 + (barTime * 19), 0 + (barTime * 19), 1));
        songNotes.Add(new NoteClass(c4, 8 + (barTime * 19), 8 + (barTime * 19), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 19), 48 + (barTime * 19), 1));

        // Bar 21
        songNotes.Add(new NoteClass(a3, 0 + (barTime * 20), 0 + (barTime * 20), 1));
        songNotes.Add(new NoteClass(d3, 16 + (barTime * 20), 16 + (barTime * 20), 1));
        songNotes.Add(new NoteClass(f3, 32 + (barTime * 20), 32 + (barTime * 20), 1));
        songNotes.Add(new NoteClass(g3, 40 + (barTime * 20), 40 + (barTime * 20), 1));

        // Bar 22
        songNotes.Add(new NoteClass(a3, 0 + (barTime * 21), 32 + (barTime * 21), 1));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 21), 32 + (barTime * 21), 1));

        //Left Hand

        // Bar 1
        songNotes.Add(new NoteClass(d2, 0, 48, 2));

        songNotes.Add(new NoteClass(f2, 16, 16, 2));
        songNotes.Add(new NoteClass(a2, 16, 16, 2));

        songNotes.Add(new NoteClass(f2, 32, 32, 2));
        songNotes.Add(new NoteClass(a2, 32, 32, 2));

        // Bar 2
        songNotes.Add(new NoteClass(e2, 0 + (barTime), 48 + (barTime), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime), 48 + (barTime), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime), 48 + (barTime), 2));

        // Bar 3
        songNotes.Add(new NoteClass(f2, 0 + (barTime * 2), 48 + (barTime * 2), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * 2), 16 + (barTime * 2), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * 2), 16 + (barTime * 2), 2));

        songNotes.Add(new NoteClass(a2, 32 + (barTime * 2), 32 + (barTime * 2), 2));
        songNotes.Add(new NoteClass(c3, 32 + (barTime * 2), 32 + (barTime * 2), 2));

        // Bar 4
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 3), 48 + (barTime * 3), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 3), 48 + (barTime * 3), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 3), 48 + (barTime * 3), 2));

        // Bar 5
        songNotes.Add(new NoteClass(d2, 0 + (barTime * 4), 48 + (barTime * 4), 2));

        songNotes.Add(new NoteClass(f2, 16 + (barTime * 4), 16 + (barTime * 4), 2));
        songNotes.Add(new NoteClass(a2, 16 + (barTime * 4), 16 + (barTime * 4), 2));

        songNotes.Add(new NoteClass(f2, 32 + (barTime * 4), 32 + (barTime * 4), 2));
        songNotes.Add(new NoteClass(a2, 32 + (barTime * 4), 32 + (barTime * 4), 2));

        // Bar 6
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 5), 48 + (barTime * 5), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 5), 48 + (barTime * 5), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 5), 48 + (barTime * 5), 2));

        // Bar 7
        songNotes.Add(new NoteClass(f2, 0 + (barTime * 6), 48 + (barTime * 6), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * 6), 16 + (barTime * 6), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * 6), 16 + (barTime * 6), 2));

        songNotes.Add(new NoteClass(a2, 32 + (barTime * 6), 32 + (barTime * 6), 2));
        songNotes.Add(new NoteClass(c3, 32 + (barTime * 6), 32 + (barTime * 6), 2));

        // Bar 8
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 7), 48 + (barTime * 7), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 7), 16 + (barTime * 7), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 7), 16 + (barTime * 7), 2));

        // Bar 9
        songNotes.Add(new NoteClass(d2, 0 + (barTime * 8), 48 + (barTime * 8), 2));

        songNotes.Add(new NoteClass(f2, 16 + (barTime * 8), 16 + (barTime * 8), 2));
        songNotes.Add(new NoteClass(a2, 16 + (barTime * 8), 16 + (barTime * 8), 2));

        songNotes.Add(new NoteClass(f2, 32 + (barTime * 8), 32 + (barTime * 8), 2));
        songNotes.Add(new NoteClass(a2, 32 + (barTime * 8), 32 + (barTime * 8), 2));

        // Bar 10
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 9), 48 + (barTime * 9), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 9), 48 + (barTime * 9), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 9), 48 + (barTime * 9), 2));

        // Bar 11
        songNotes.Add(new NoteClass(f2, 0 + (barTime * 10), 48 + (barTime * 10), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * 10), 16 + (barTime * 10), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * 10), 16 + (barTime * 10), 2));

        songNotes.Add(new NoteClass(a2, 32 + (barTime * 10), 32 + (barTime * 10), 2));
        songNotes.Add(new NoteClass(c3, 32 + (barTime * 10), 32 + (barTime * 10), 2));

        // Bar 12
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 11), 48 + (barTime * 11), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 11), 48 + (barTime * 11), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 11), 48 + (barTime * 11), 2));

        // Bar 13
        songNotes.Add(new NoteClass(b2, 0 + (barTime * 12), 48 + (barTime * 12), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * 12), 16 + (barTime * 12), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 12), 16 + (barTime * 12), 2));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * 12), 32 + (barTime * 12), 2));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 12), 32 + (barTime * 12), 2));

        // Bar 14
        songNotes.Add(new NoteClass(f2, 0 + (barTime * 13), 48 + (barTime * 13), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * 13), 8 + (barTime * 13), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * 13), 48 + (barTime * 13), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 13), 48 + (barTime * 13), 2));

        // Bar 15
        songNotes.Add(new NoteClass(b2, 0 + (barTime * 14), 48 + (barTime * 14), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * 14), 16 + (barTime * 14), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 14), 16 + (barTime * 14), 2));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * 14), 32 + (barTime * 14), 2));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 14), 32 + (barTime * 14), 2));

        // Bar 16
        songNotes.Add(new NoteClass(b2, 0 + (barTime * 15), 48 + (barTime * 15), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * 15), 48 + (barTime * 15), 2));
        songNotes.Add(new NoteClass(e3, 16 + (barTime * 15), 48 + (barTime * 15), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 15), 48 + (barTime * 15), 2));

        // Bar 17
        songNotes.Add(new NoteClass(d2, 0 + (barTime * 16), 48 + (barTime * 16), 2));

        songNotes.Add(new NoteClass(f2, 16 + (barTime * 16), 16 + (barTime * 16), 2));
        songNotes.Add(new NoteClass(a2, 16 + (barTime * 16), 16 + (barTime * 16), 2));

        songNotes.Add(new NoteClass(f2, 32 + (barTime * 16), 32 + (barTime * 16), 2));
        songNotes.Add(new NoteClass(a2, 32 + (barTime * 16), 32 + (barTime * 16), 2));

        // Bar 18
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 17), 48 + (barTime * 17), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 17), 48 + (barTime * 17), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 17), 48 + (barTime * 17), 2));

        // Bar 19
        songNotes.Add(new NoteClass(f2, 0 + (barTime * 18), 48 + (barTime * 18), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * 18), 16 + (barTime * 18), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * 18), 16 + (barTime * 18), 2));

        songNotes.Add(new NoteClass(a2, 32 + (barTime * 18), 32 + (barTime * 18), 2));
        songNotes.Add(new NoteClass(c3, 32 + (barTime * 18), 32 + (barTime * 18), 2));

        // Bar 20
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 19), 48 + (barTime * 19), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 19), 48 + (barTime * 19), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 19), 48 + (barTime * 19), 2));

        // Bar 21
        songNotes.Add(new NoteClass(b2, 0 + (barTime * 20), 48 + (barTime * 20), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * 20), 48 + (barTime * 20), 2));
        songNotes.Add(new NoteClass(e3, 16 + (barTime * 20), 48 + (barTime * 20), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 20), 48 + (barTime * 20), 2));
    }
}
