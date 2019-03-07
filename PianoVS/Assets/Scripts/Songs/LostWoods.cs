using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Josh Sadoway
 * Last Edited on : March 7th 2019
 * This script is designed to hold the notes for the Song Song of Storms
**/
public class LostWoods : Songholder
{
	public LostWoods()
	{
        songNotes = new List<NoteClass>();
        SetBPM(140);
        SetTimeSignature(2);
        SetMaxBeat(1000);
        int barTime = timeSignature * 16;
        int leftBarCount = 0, rightBarCount = 0;

        //Right Hand

        // Bar 1
        songNotes.Add(new NoteClass(f3, 0, 0, 1));
        songNotes.Add(new NoteClass(a3, 8, 8, 1));
        songNotes.Add(new NoteClass(b3, 16, 32, 1));

        rightBarCount++;

        // Bar 2
        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(a3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 3
        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(a3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e4, 24 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 4
        songNotes.Add(new NoteClass(d4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 5
        songNotes.Add(new NoteClass(b3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 16 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 6
        songNotes.Add(new NoteClass(d3, 24 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 7
        songNotes.Add(new NoteClass(e3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 16 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 8
        //HELD NOTES
        rightBarCount++;

        // Bar 9
        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(a3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 10
        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(a3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 11
        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(a3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e4, 24 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 12
        songNotes.Add(new NoteClass(d4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 13
        songNotes.Add(new NoteClass(e4, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g3, 16 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 14
        songNotes.Add(new NoteClass(b3, 24 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 15
        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(d3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 16 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 16
        // HELD NOTES
        rightBarCount++;

        // Bar 17
        songNotes.Add(new NoteClass(d3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(f3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 18
        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(a3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 19
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 16 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 20
        //HELD NOTES
        rightBarCount++;

        // Bar 21
        songNotes.Add(new NoteClass(d3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(e3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 22
        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(a3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(b3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(d4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 23
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e4, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(d4, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(f4, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(e4, 16 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g4, 16 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 24
        // HELD NOTES
        rightBarCount++;

        // Bar 25
        songNotes.Add(new NoteClass(d3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(f3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 26
        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(a3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 26
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(b3, 8 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(e3, 16 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 27
        // HELD NOTE
        rightBarCount++;


        //Left Hand

        // Bar 1
        songNotes.Add(new NoteClass(f2, 0, 0, 2));

        songNotes.Add(new NoteClass(a2, 8, 8, 2));
        songNotes.Add(new NoteClass(c3, 8, 8, 2));

        songNotes.Add(new NoteClass(a2, 16, 16, 2));
        songNotes.Add(new NoteClass(c3, 16, 16, 2));

        songNotes.Add(new NoteClass(a2, 24, 24, 2));
        songNotes.Add(new NoteClass(c3, 24, 24, 2));

        leftBarCount++;

        // Bar 2
        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 3
        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 4
        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 5
        songNotes.Add(new NoteClass(e2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 6
        songNotes.Add(new NoteClass(e2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 7
        songNotes.Add(new NoteClass(e2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 8
        songNotes.Add(new NoteClass(e2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 9
        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 10
        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 11
        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 12
        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 13
        songNotes.Add(new NoteClass(e2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 14
        songNotes.Add(new NoteClass(e2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 15
        songNotes.Add(new NoteClass(e2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 16
        songNotes.Add(new NoteClass(e2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 17
        songNotes.Add(new NoteClass(d2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(d2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 18
        songNotes.Add(new NoteClass(g1, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(d2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g1, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(d2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 19
        songNotes.Add(new NoteClass(c2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 20
        songNotes.Add(new NoteClass(a1, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(e2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a1, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(e2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 21
        songNotes.Add(new NoteClass(d2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(d2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 22
        songNotes.Add(new NoteClass(g1, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(d2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g1, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(d2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 23
        songNotes.Add(new NoteClass(c2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 24
        songNotes.Add(new NoteClass(a1, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(e2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a1, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(e2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 25
        songNotes.Add(new NoteClass(d2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(d2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 26
        songNotes.Add(new NoteClass(g1, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(d2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g1, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(d2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 27
        songNotes.Add(new NoteClass(c2, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c2, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 28
        songNotes.Add(new NoteClass(a1, 0 + (barTime * leftBarCount), 0 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(e2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(a2, 8 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(a1, 16 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(e2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(a2, 24 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        leftBarCount++;
    }
}
