using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Josh Sadoway
 * Last Edited on : March 5th 2019
 * This script is designed to hold the notes for the Song Song of Storms
**/
public class SongOfStorms : Songholder
{
	public SongOfStorms()
	{
        songNotes = new List<NoteClass>();
        SetBPM(200);
        SetTimeSignature(3);
        SetMaxBeat(2352);
        SetSongName("Song of Storms");
        int barTime = timeSignature * 16;

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

        // Bar 23
        songNotes.Add(new NoteClass(d4, 16 + (barTime * 22), 16 + (barTime * 22), 1));

        songNotes.Add(new NoteClass(d3, 16 + (barTime * 22), 16 + (barTime * 22), 1));
        songNotes.Add(new NoteClass(f3, 16 + (barTime * 22), 16 + (barTime * 22), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 22), 16 + (barTime * 22), 1));

        songNotes.Add(new NoteClass(d3, 32 + (barTime * 22), 32 + (barTime * 22), 1));
        songNotes.Add(new NoteClass(f3, 32 + (barTime * 22), 32 + (barTime * 22), 1));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 22), 32 + (barTime * 22), 1));

        // Bar 24
        songNotes.Add(new NoteClass(e3, 8 + (barTime * 23), 48 + (barTime * 23), 1));
        songNotes.Add(new NoteClass(g3, 16 + (barTime * 23), 48 + (barTime * 23), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 23), 48 + (barTime * 23), 1));

        // Bar 25
        songNotes.Add(new NoteClass(f3, 16 + (barTime * 24), 16 + (barTime * 24), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 24), 16 + (barTime * 24), 1));
        songNotes.Add(new NoteClass(c4, 16 + (barTime * 24), 16 + (barTime * 24), 1));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * 24), 32 + (barTime * 24), 1));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 24), 32 + (barTime * 24), 1));
        songNotes.Add(new NoteClass(c4, 32 + (barTime * 24), 32 + (barTime * 24), 1));

        // Bar 26
        songNotes.Add(new NoteClass(e3, 8 + (barTime * 25), 48 + (barTime * 25), 1));
        songNotes.Add(new NoteClass(g3, 16 + (barTime * 25), 48 + (barTime * 25), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 25), 48 + (barTime * 25), 1));

        // Bar 27
        songNotes.Add(new NoteClass(d3, 16 + (barTime * 26), 16 + (barTime * 26), 1));
        songNotes.Add(new NoteClass(f3, 16 + (barTime * 26), 16 + (barTime * 26), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 26), 16 + (barTime * 26), 1));

        songNotes.Add(new NoteClass(d3, 32 + (barTime * 26), 32 + (barTime * 26), 1));
        songNotes.Add(new NoteClass(f3, 32 + (barTime * 26), 32 + (barTime * 26), 1));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 26), 32 + (barTime * 26), 1));

        // Bar 28
        songNotes.Add(new NoteClass(e3, 8 + (barTime * 27), 48 + (barTime * 27), 1));
        songNotes.Add(new NoteClass(g3, 16 + (barTime * 27), 48 + (barTime * 27), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 27), 48 + (barTime * 27), 1));

        // Bar 29
        songNotes.Add(new NoteClass(f3, 16 + (barTime * 28), 16 + (barTime * 28), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 28), 16 + (barTime * 28), 1));
        songNotes.Add(new NoteClass(c4, 16 + (barTime * 28), 16 + (barTime * 28), 1));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * 28), 32 + (barTime * 28), 1));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 28), 32 + (barTime * 28), 1));
        songNotes.Add(new NoteClass(c4, 32 + (barTime * 28), 32 + (barTime * 28), 1));

        // Bar 30
        songNotes.Add(new NoteClass(e3, 8 + (barTime * 29), 48 + (barTime * 29), 1));
        songNotes.Add(new NoteClass(g3, 16 + (barTime * 29), 48 + (barTime * 29), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 29), 48 + (barTime * 29), 1));

        // Bar 31
        songNotes.Add(new NoteClass(d3, 0 + (barTime * 30), 0 + (barTime * 30), 1));
        songNotes.Add(new NoteClass(f3, 8 + (barTime * 30), 8 + (barTime * 30), 1));
        songNotes.Add(new NoteClass(d4, 16 + (barTime * 30), 48 + (barTime * 30), 1));

        // Bar 32
        songNotes.Add(new NoteClass(d3, 0 + (barTime * 31), 0 + (barTime * 31), 1));
        songNotes.Add(new NoteClass(f3, 8 + (barTime * 31), 8 + (barTime * 31), 1));
        songNotes.Add(new NoteClass(d4, 16 + (barTime * 31), 16 + (barTime * 31), 1));

        // Bar 33
        songNotes.Add(new NoteClass(e4, 0 + (barTime * 32), 0 + (barTime * 32), 1));
        songNotes.Add(new NoteClass(f4, 24 + (barTime * 32), 24 + (barTime * 32), 1));
        songNotes.Add(new NoteClass(e4, 32 + (barTime * 32), 32 + (barTime * 32), 1));
        songNotes.Add(new NoteClass(f4, 40 + (barTime * 32), 40 + (barTime * 32), 1));

        // Bar 34
        songNotes.Add(new NoteClass(e4, 0 + (barTime * 33), 0 + (barTime * 33), 1));
        songNotes.Add(new NoteClass(c4, 8 + (barTime * 33), 8 + (barTime * 33), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 33), 48 + (barTime * 33), 1));

        // Bar 35
        songNotes.Add(new NoteClass(a3, 0 + (barTime * 34), 0 + (barTime * 34), 1));
        songNotes.Add(new NoteClass(d3, 16 + (barTime * 34), 16 + (barTime * 34), 1));
        songNotes.Add(new NoteClass(f3, 32 + (barTime * 34), 32 + (barTime * 34), 1));
        songNotes.Add(new NoteClass(g3, 40 + (barTime * 34), 40 + (barTime * 34), 1));

        // Bar 36
        songNotes.Add(new NoteClass(a3, 0 + (barTime * 35), 48 + (barTime * 35), 1));

        // Bar 37
        songNotes.Add(new NoteClass(a3, 0 + (barTime * 36), 0 + (barTime * 36), 1));
        songNotes.Add(new NoteClass(d3, 16 + (barTime * 36), 16 + (barTime * 36), 1));
        songNotes.Add(new NoteClass(f3, 36 + (barTime * 36), 36 + (barTime * 36), 1));
        songNotes.Add(new NoteClass(g3, 40 + (barTime * 36), 40 + (barTime * 36), 1));

        // Bar 38
        songNotes.Add(new NoteClass(e3, 0 + (barTime * 37), 48 + (barTime * 37), 1));

        // Bar 39
        songNotes.Add(new NoteClass(d3, 0 + (barTime * 38), 0 + (barTime * 38), 1));
        songNotes.Add(new NoteClass(f3, 8 + (barTime * 38), 8 + (barTime * 38), 1));
        songNotes.Add(new NoteClass(d4, 16 + (barTime * 38), 48 + (barTime * 38), 1));

        // Bar 40
        songNotes.Add(new NoteClass(d3, 0 + (barTime * 39), 0 + (barTime * 39), 1));
        songNotes.Add(new NoteClass(f3, 8 + (barTime * 39), 8 + (barTime * 39), 1));
        songNotes.Add(new NoteClass(d4, 16 + (barTime * 39), 16 + (barTime * 39), 1));

        // Bar 41
        songNotes.Add(new NoteClass(e4, 0 + (barTime * 40), 0 + (barTime * 40), 1));
        songNotes.Add(new NoteClass(f4, 24 + (barTime * 40), 24 + (barTime * 40), 1));
        songNotes.Add(new NoteClass(e4, 32 + (barTime * 40), 32 + (barTime * 40), 1));
        songNotes.Add(new NoteClass(f4, 40 + (barTime * 40), 40 + (barTime * 40), 1));

        // Bar 42
        songNotes.Add(new NoteClass(e4, 0 + (barTime * 41), 0 + (barTime * 41), 1));
        songNotes.Add(new NoteClass(c4, 8 + (barTime * 41), 8 + (barTime * 41), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 41), 48 + (barTime * 41), 1));

        // Bar 43
        songNotes.Add(new NoteClass(a3, 0 + (barTime * 42), 0 + (barTime * 42), 1));
        songNotes.Add(new NoteClass(d3, 16 + (barTime * 42), 16 + (barTime * 42), 1));
        songNotes.Add(new NoteClass(f3, 32 + (barTime * 42), 32 + (barTime * 42), 1));
        songNotes.Add(new NoteClass(g3, 40 + (barTime * 42), 40 + (barTime * 42), 1));

        // Bar 44
        songNotes.Add(new NoteClass(a3, 0 + (barTime * 43), 32 + (barTime * 43), 1));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 43), 32 + (barTime * 43), 1));

        // Bar 45
        songNotes.Add(new NoteClass(d4, 16 + (barTime * 44), 16 + (barTime * 44), 1));

        songNotes.Add(new NoteClass(d3, 16 + (barTime * 44), 16 + (barTime * 44), 1));
        songNotes.Add(new NoteClass(f3, 16 + (barTime * 44), 16 + (barTime * 44), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 44), 16 + (barTime * 44), 1));

        songNotes.Add(new NoteClass(d3, 32 + (barTime * 44), 32 + (barTime * 44), 1));
        songNotes.Add(new NoteClass(f3, 32 + (barTime * 44), 32 + (barTime * 44), 1));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 44), 32 + (barTime * 44), 1));

        // Bar 46
        songNotes.Add(new NoteClass(e3, 8 + (barTime * 45), 48 + (barTime * 45), 1));
        songNotes.Add(new NoteClass(g3, 16 + (barTime * 45), 48 + (barTime * 45), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 45), 48 + (barTime * 45), 1));

        // Bar 47
        songNotes.Add(new NoteClass(f3, 16 + (barTime * 46), 16 + (barTime * 46), 1));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 46), 16 + (barTime * 46), 1));
        songNotes.Add(new NoteClass(c4, 16 + (barTime * 46), 16 + (barTime * 46), 1));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * 46), 32 + (barTime * 46), 1));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 46), 32 + (barTime * 46), 1));
        songNotes.Add(new NoteClass(c4, 32 + (barTime * 46), 32 + (barTime * 46), 1));

        // Bar 48
        songNotes.Add(new NoteClass(e3, 8 + (barTime * 47), 48 + (barTime * 47), 1));
        songNotes.Add(new NoteClass(g3, 16 + (barTime * 47), 48 + (barTime * 47), 1));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 47), 48 + (barTime * 47), 1));

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

        songNotes.Add(new NoteClass(f3, 16 + (barTime * 20), 16 + (barTime * 20), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 20), 16 + (barTime * 20), 2));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * 20), 32 + (barTime * 20), 2));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 20), 32 + (barTime * 20), 2));

        // Bar 22
        songNotes.Add(new NoteClass(b2, 0 + (barTime * 21), 48 + (barTime * 21), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * 21), 48 + (barTime * 21), 2));
        songNotes.Add(new NoteClass(e3, 16 + (barTime * 21), 48 + (barTime * 21), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 21), 48 + (barTime * 21), 2));

        // Bar 23
        songNotes.Add(new NoteClass(d2, 0 + (barTime * 22), 48 + (barTime * 22), 2));

        songNotes.Add(new NoteClass(f2, 16 + (barTime * 22), 16 + (barTime * 22), 2));
        songNotes.Add(new NoteClass(a2, 16 + (barTime * 22), 16 + (barTime * 22), 2));

        songNotes.Add(new NoteClass(f2, 32 + (barTime * 22), 32 + (barTime * 22), 2));
        songNotes.Add(new NoteClass(a2, 32 + (barTime * 22), 32 + (barTime * 22), 2));

        // Bar 24
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 23), 48 + (barTime * 23), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 23), 48 + (barTime * 23), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 23), 48 + (barTime * 23), 2));

        // Bar 25
        songNotes.Add(new NoteClass(f2, 0 + (barTime * 24), 48 + (barTime * 24), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * 24), 16 + (barTime * 24), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * 24), 16 + (barTime * 24), 2));

        songNotes.Add(new NoteClass(a2, 32 + (barTime * 24), 32 + (barTime * 24), 2));
        songNotes.Add(new NoteClass(c3, 32 + (barTime * 24), 32 + (barTime * 24), 2));

        // Bar 26
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 25), 48 + (barTime * 25), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 25), 48 + (barTime * 25), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 25), 48 + (barTime * 25), 2));

        // Bar 27
        songNotes.Add(new NoteClass(d2, 0 + (barTime * 26), 48 + (barTime * 26), 2));

        songNotes.Add(new NoteClass(f2, 16 + (barTime * 26), 16 + (barTime * 26), 2));
        songNotes.Add(new NoteClass(a2, 16 + (barTime * 26), 16 + (barTime * 26), 2));

        songNotes.Add(new NoteClass(f2, 32 + (barTime * 26), 32 + (barTime * 26), 2));
        songNotes.Add(new NoteClass(a2, 32 + (barTime * 26), 32 + (barTime * 26), 2));

        // Bar 28
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 27), 48 + (barTime * 27), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 27), 48 + (barTime * 27), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 27), 48 + (barTime * 27), 2));

        // Bar 29
        songNotes.Add(new NoteClass(f2, 0 + (barTime * 28), 48 + (barTime * 28), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * 28), 16 + (barTime * 28), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * 28), 16 + (barTime * 28), 2));

        songNotes.Add(new NoteClass(a2, 32 + (barTime * 28), 32 + (barTime * 28), 2));
        songNotes.Add(new NoteClass(c3, 32 + (barTime * 28), 32 + (barTime * 28), 2));

        // Bar 30
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 29), 48 + (barTime * 29), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 29), 48 + (barTime * 29), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 29), 48 + (barTime * 29), 2));

        // Bar 31
        songNotes.Add(new NoteClass(d2, 0 + (barTime * 30), 48 + (barTime * 30), 2));

        songNotes.Add(new NoteClass(f2, 16 + (barTime * 30), 16 + (barTime * 30), 2));
        songNotes.Add(new NoteClass(a2, 16 + (barTime * 30), 16 + (barTime * 30), 2));

        songNotes.Add(new NoteClass(f2, 32 + (barTime * 30), 32 + (barTime * 30), 2));
        songNotes.Add(new NoteClass(a2, 32 + (barTime * 30), 32 + (barTime * 30), 2));

        // Bar 32
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 31), 48 + (barTime * 31), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 31), 48 + (barTime * 31), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 31), 48 + (barTime * 31), 2));

        // Bar 33
        songNotes.Add(new NoteClass(f2, 0 + (barTime * 32), 48 + (barTime * 32), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * 32), 16 + (barTime * 32), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * 32), 16 + (barTime * 32), 2));

        songNotes.Add(new NoteClass(a2, 32 + (barTime * 32), 32 + (barTime * 32), 2));
        songNotes.Add(new NoteClass(c3, 32 + (barTime * 32), 32 + (barTime * 32), 2));

        // Bar 34
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 33), 48 + (barTime * 33), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 33), 48 + (barTime * 33), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 33), 48 + (barTime * 33), 2));

        // Bar 35
        songNotes.Add(new NoteClass(b2, 0 + (barTime * 34), 48 + (barTime * 34), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * 34), 16 + (barTime * 34), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 34), 16 + (barTime * 34), 2));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * 34), 32 + (barTime * 34), 2));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 34), 32 + (barTime * 34), 2));

        // Bar 36
        songNotes.Add(new NoteClass(f2, 0 + (barTime * 35), 48 + (barTime * 35), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * 35), 8 + (barTime * 35), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * 35), 48 + (barTime * 35), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 35), 48 + (barTime * 35), 2));

        // Bar 37
        songNotes.Add(new NoteClass(b2, 0 + (barTime * 36), 48 + (barTime * 36), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * 36), 16 + (barTime * 36), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 36), 16 + (barTime * 36), 2));

        songNotes.Add(new NoteClass(f3, 36 + (barTime * 36), 36 + (barTime * 36), 2));
        songNotes.Add(new NoteClass(a3, 36 + (barTime * 36), 36 + (barTime * 36), 2));

        // Bar 38
        songNotes.Add(new NoteClass(b2, 0 + (barTime * 37), 48 + (barTime * 37), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * 37), 48 + (barTime * 37), 2));
        songNotes.Add(new NoteClass(e3, 16 + (barTime * 37), 48 + (barTime * 37), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 37), 48 + (barTime * 37), 2));

        // Bar 39
        songNotes.Add(new NoteClass(d2, 0 + (barTime * 38), 48 + (barTime * 38), 2));

        songNotes.Add(new NoteClass(f2, 16 + (barTime * 38), 16 + (barTime * 38), 2));
        songNotes.Add(new NoteClass(a2, 16 + (barTime * 38), 16 + (barTime * 38), 2));

        songNotes.Add(new NoteClass(f2, 32 + (barTime * 38), 32 + (barTime * 38), 2));
        songNotes.Add(new NoteClass(a2, 32 + (barTime * 38), 32 + (barTime * 38), 2));

        // Bar 40
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 39), 48 + (barTime * 39), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 39), 48 + (barTime * 39), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 39), 48 + (barTime * 39), 2));

        // Bar 41
        songNotes.Add(new NoteClass(f2, 0 + (barTime * 40), 48 + (barTime * 40), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * 40), 16 + (barTime * 40), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * 40), 16 + (barTime * 40), 2));

        songNotes.Add(new NoteClass(a2, 32 + (barTime * 40), 32 + (barTime * 40), 2));
        songNotes.Add(new NoteClass(c3, 32 + (barTime * 40), 32 + (barTime * 40), 2));

        // Bar 42
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 41), 48 + (barTime * 41), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 41), 48 + (barTime * 41), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 41), 48 + (barTime * 41), 2));

        // Bar 43
        songNotes.Add(new NoteClass(b2, 0 + (barTime * 42), 48 + (barTime * 42), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * 42), 16 + (barTime * 42), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 42), 16 + (barTime * 42), 2));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * 42), 32 + (barTime * 42), 2));
        songNotes.Add(new NoteClass(a3, 32 + (barTime * 42), 32 + (barTime * 42), 2));

        // Bar 44
        songNotes.Add(new NoteClass(b2, 0 + (barTime * 43), 48 + (barTime * 43), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * 43), 48 + (barTime * 43), 2));
        songNotes.Add(new NoteClass(e3, 16 + (barTime * 43), 48 + (barTime * 43), 2));
        songNotes.Add(new NoteClass(a3, 16 + (barTime * 43), 48 + (barTime * 43), 2));

        // Bar 45
        songNotes.Add(new NoteClass(d2, 0 + (barTime * 44), 48 + (barTime * 44), 2));

        songNotes.Add(new NoteClass(f2, 16 + (barTime * 44), 16 + (barTime * 44), 2));
        songNotes.Add(new NoteClass(a2, 16 + (barTime * 44), 16 + (barTime * 44), 2));

        songNotes.Add(new NoteClass(f2, 32 + (barTime * 44), 32 + (barTime * 44), 2));
        songNotes.Add(new NoteClass(a2, 32 + (barTime * 44), 32 + (barTime * 44), 2));

        // Bar 46
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 45), 48 + (barTime * 45), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 45), 48 + (barTime * 45), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 45), 48 + (barTime * 45), 2));

        // Bar 47
        songNotes.Add(new NoteClass(f2, 0 + (barTime * 46), 48 + (barTime * 46), 2));

        songNotes.Add(new NoteClass(a2, 16 + (barTime * 46), 16 + (barTime * 46), 2));
        songNotes.Add(new NoteClass(c3, 16 + (barTime * 46), 16 + (barTime * 46), 2));

        songNotes.Add(new NoteClass(a2, 32 + (barTime * 46), 32 + (barTime * 46), 2));
        songNotes.Add(new NoteClass(c3, 32 + (barTime * 46), 32 + (barTime * 46), 2));

        // Bar 48
        songNotes.Add(new NoteClass(e2, 0 + (barTime * 47), 48 + (barTime * 47), 2));
        songNotes.Add(new NoteClass(g2, 16 + (barTime * 47), 48 + (barTime * 47), 2));
        songNotes.Add(new NoteClass(b3, 16 + (barTime * 47), 48 + (barTime * 47), 2));
    }
}
