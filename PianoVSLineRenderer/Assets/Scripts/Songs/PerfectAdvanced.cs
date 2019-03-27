using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Josh Sadoway
 * Last Edited on : January 31st 2019
 * This script is designed to hold the notes for the Song hotcross buns
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

        // Bar 2
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 44 + (barTime * rightBarCount), 68 + (barTime * rightBarCount), 1));


        rightBarCount++;

        // Bar 3
        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 4
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 36 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 80 + (barTime * rightBarCount), 1));


        rightBarCount++;

        // Bar 5

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 6

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 7

        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 68 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 8

        songNotes.Add(new NoteClass(f3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 36 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 36 + (barTime * rightBarCount), 60 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 9

        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 10

        songNotes.Add(new NoteClass(g3, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 44 + (barTime * rightBarCount), 60 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 11

        songNotes.Add(new NoteClass(aSharp3, 12 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 12

        songNotes.Add(new NoteClass(dSharp4, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 13

        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 8 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 68 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 14

        songNotes.Add(new NoteClass(f3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 15

        songNotes.Add(new NoteClass(cSharp4, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(cSharp4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 16

        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 8 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 17

        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 28 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 28 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 44 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 18

        songNotes.Add(new NoteClass(dSharp4, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 19

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 44 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 20

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Bar 21

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 20 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 20 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 44 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 44 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        // Left Hand

        // Bar 1

        songNotes.Add(new NoteClass(gSharp2, 0, 8, 2));

        songNotes.Add(new NoteClass(c3, 8, 32, 2));

        songNotes.Add(new NoteClass(c3, 32, 56, 2));

        leftBarCount++;

        // Bar 2

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 3

        songNotes.Add(new NoteClass(gSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 4

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 5

        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 6

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 7

        songNotes.Add(new NoteClass(cSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 8

        songNotes.Add(new NoteClass(dSharp3, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 9

        songNotes.Add(new NoteClass(dSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 40 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 10

        songNotes.Add(new NoteClass(aSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 11

        songNotes.Add(new NoteClass(gSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 12

        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 13

        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 14

        songNotes.Add(new NoteClass(f3, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 15

        songNotes.Add(new NoteClass(cSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 16

        songNotes.Add(new NoteClass(f3, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(gSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(cSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 17

        songNotes.Add(new NoteClass(dSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 24 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(g3, 24 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(aSharp2, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 18

        songNotes.Add(new NoteClass(g3, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 19

        songNotes.Add(new NoteClass(gSharp2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 20

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(dSharp3, 40 + (barTime * leftBarCount), 48 + (barTime * leftBarCount), 2));

        leftBarCount++;

        // Bar 21

        songNotes.Add(new NoteClass(f2, 0 + (barTime * leftBarCount), 8 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 8 + (barTime * leftBarCount), 16 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 16 + (barTime * leftBarCount), 32 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(c3, 32 + (barTime * leftBarCount), 40 + (barTime * leftBarCount), 2));

        songNotes.Add(new NoteClass(f3, 40 + (barTime * leftBarCount), 56 + (barTime * leftBarCount), 2));

        leftBarCount++;
    }
}