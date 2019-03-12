using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///Author: Noah Rittenhouse
///This script will handle data universal among the 4 players
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 7-Mar-2019
///Dependencies: The four notespawners MUST have the NoteSpawner tag to change their song output
///
public class GameDataManager : MonoBehaviour
{
    public static bool voteInProgress;//Bool that tracks if vote is ongoing
    static int currentVote, totalVotes;//Vote count, and total votes sent in
    static int aiCount;//How many AI there are active
    static int currentSongID, newSongID;
    static GameObject[] noteSpawners;

    void Start()
    {
        voteInProgress = false;
        currentVote = 0;
        aiCount = 3;
        currentSongID = 0;
        newSongID = -1;
        noteSpawners = GameObject.FindGameObjectsWithTag("NoteSpawner");
    }
    void Update()
    {
        Debug.Log(voteInProgress);
        Debug.Log(currentVote);
        Debug.Log(currentSongID);
        Debug.Log(newSongID);
        if (currentVote == (4 - aiCount))//If everyone agrees, AI doesnt vote so lower needed score in case of AI activeness
        {
            //VOTE PASSED
            foreach(GameObject noteSpawner in noteSpawners)//For the 4 note spawners
            {
                noteSpawner.GetComponent<NoteSpawning>().ChangeSong(newSongID);//Set the song choice, reset the beat, and set the bpm and time signature to the songs
                noteSpawner.GetComponent<NoteSpawning>().ResetHoldNotes();
                SetCurrentSongID(newSongID);
            }
            ResetVote();
        }
        else if(totalVotes == (4 - aiCount))//If all players have voted and failed, reset
        {
            ResetVote();
        }
    }

    public static void IncrementVote(int vote)//Simply increments the vote based on the players vote choice
    {
        //1 = yes
        //-1 = nos
        currentVote += vote;//If all say yes then the current vote will be 4 unless there is AI active
        totalVotes++;
    }

    public static void SetNewSongID(int songID)
    {
        newSongID = songID;
    }

    public static void SetCurrentSongID(int songID)
    {
        currentSongID = songID;
    }

    public static string GetSongName()
    {
        return noteSpawners[0].GetComponent<NoteSpawning>().songs[newSongID].GetSongName();
    }

    public void ResetVote()
    {
        voteInProgress = false;
        currentVote = 0;
        totalVotes = 0;
        newSongID = -1;
    }
}
