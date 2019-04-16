using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Josh Sadoway
 * Last Edited on : January 31st 2019
 * This script is designed to hold the notes for the song Perfect
**/
public class PerfectAdvanced : Songholder
{
    int barTime;
    int rightBarCount;
    int leftBarCount;
    public PerfectAdvanced()
    {
        // Flats In Song: Ab, Bb, Db, Eb

        SetBPM(100);
        SetTimeSignature(3);
        SetSongName("Perfect (Advanced)");
        SetMaxBeat(2640);
        SetDifficulty(2);

        barTime = (GetTimeSignature() * 16);

        rightBarCount = 0;
        leftBarCount = 0;

		songNotes = new List<NoteClass>();

        //Right Hand

        // Bar 1
        songNotes.Add(new NoteClass(gSharp3, 0, 16, 1));

        songNotes.Add(new NoteClass(dSharp3, 16, 24, 1));

        songNotes.Add(new NoteClass(gSharp3, 24, 40, 1));

        songNotes.Add(new NoteClass(dSharp3, 40, 48, 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(gSharp2, 0, 8, 2));

        songNotes.Add(new NoteClass(c3, 8, 32, 2));

        songNotes.Add(new NoteClass(c3, 32, 56, 2));

        leftBarCount++;

        // Bar 2
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 44 + (barTime * rightBarCount), 68 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 3
        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(gSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 4
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 36 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 80 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 5

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 6

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;


        // Bar 7

        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 68 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(cSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 8

        songNotes.Add(new NoteClass(f3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 36 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 36 + (barTime * rightBarCount), 60 + (barTime * rightBarCount), 1));

        rightBarCount++;

        songNotes.Add(new NoteClass(dSharp3, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 9

        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(dSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 40 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 10

        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 44 + (barTime * rightBarCount), 60 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(aSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 11

        songNotes.Add(new NoteClass(aSharp3, 12 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(gSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 12

        songNotes.Add(new NoteClass(dSharp4, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 13

        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 8 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 68 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 14

        songNotes.Add(new NoteClass(f3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f3, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 15

        songNotes.Add(new NoteClass(cSharp4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(cSharp4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(cSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 16

        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 8 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f3, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 17

        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 28 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 28 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 44 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(dSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 18

        songNotes.Add(new NoteClass(dSharp4, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(g3, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 19

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 44 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(gSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 20

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 21

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 44 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 40 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 22

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 40 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 23

        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(cSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 24

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(cSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(dSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f3, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 25

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(cSharp4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(gSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 26

        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(dSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 27

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 44 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(gSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 28

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 29

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 44 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 40 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 30

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 40 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 31

        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 36 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 36 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 36 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(cSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 32

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(cSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(dSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 44 + (barTime * rightBarCount), 96 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f3, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 33
        // NOTES HELD

        rightBarCount++;


        songNotes.Add(new NoteClass(dSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 34

        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(dSharp4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 28 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 28 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 36 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 36 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        leftBarCount++;

        // Bar 35

        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 36
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(f4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(f4, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(cSharp1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 37
        songNotes.Add(new NoteClass(dSharp3, 0 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(gSharp1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 38

        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(dSharp4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 40 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 40 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 44 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(dSharp1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 39

        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 40
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(f4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(f4, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(cSharp1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;


        // Bar 41
        songNotes.Add(new NoteClass(dSharp3, 0 + (barTime * rightBarCount), 12 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 12 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 12 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 12 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(gSharp1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 42

        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(dSharp4, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(dSharp4, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(dSharp4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 24 + (barTime * rightBarCount), 36 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 24 + (barTime * rightBarCount), 36 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(dSharp4, 24 + (barTime * rightBarCount), 36 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 36 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 36 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(f4, 36 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(dSharp1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 43

        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(dSharp4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 44

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(f4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(f4, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(cSharp1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 45

        songNotes.Add(new NoteClass(dSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(gSharp1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 46

        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(dSharp4, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(dSharp1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 47

        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 48

        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 44 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(cSharp1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 49

        songNotes.Add(new NoteClass(dSharp3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(gSharp1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 50

        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(dSharp1, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g3, 40 + (barTime * leftBarCount), 44 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 44 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 51

        songNotes.Add(new NoteClass(c5, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(gSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 52

        songNotes.Add(new NoteClass(gSharp4, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 53

        songNotes.Add(new NoteClass(f4, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(cSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp2, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 54

        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(dSharp4, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(g4, 0 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;


        songNotes.Add(new NoteClass(dSharp2, 0 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(aSharp2, 0 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));
        songNotes.Add(new NoteClass(dSharp3, 0 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;
    }
}