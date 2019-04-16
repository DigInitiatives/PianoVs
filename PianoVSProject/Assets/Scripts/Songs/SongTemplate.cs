using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongTemplate : Songholder
{
    // Edited By: Josh Sadoway
    // Last Edited: April 16th, 2019
    // This Script is a template to create songs.
    public SongTemplate()
    {
        // Create a list of notes in the songs for NoteSpawning to access to play notes
        songNotes = new List<NoteClass>();

        // Sets the name of the song
        SetSongName("SongTemplate");

        // Sets the beats per minute of a song
        SetBPM(120);

        // Beats are a multiplier of 16. 1 beat is 16, 2 is 32.
        // If a song is 4/4 time, 4 * 16 = 64. One bar is 64 beats.
        // If a song is 3/4 time, 3 * 16 = 48. One bar is 48 beats.

        // Sets the maximum number of beats it take to complete the song
        SetMaxBeat(1000);

        // The numerator of a time signature, if the song is 3/4 time, enter the numerator which is 3.
        SetTimeSignature(3);

        // Max beats in a bar
        int barTime = timeSignature * 16;

        // You can add a bar count to make bar counting simpler:
        int rightBarCount = 0, leftBarCount = 0;

        // Adding a note
        // Example: songNotes.Add(new NoteClass((what note), (starting beat), (ending beat), (left, right, or no hand)));

        // Bar 1
        songNotes.Add(new NoteClass(0, 0 + (barTime * rightBarCount), 0 + (barTime * rightBarCount, 1)));

        rightBarCount++;

        // After you've finished the bar, adding a count allows you to easily count beats. BarTime * barCount automatically counts beats.

    }
}
