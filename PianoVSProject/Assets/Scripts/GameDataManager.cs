///Author: Noah Rittenhouse
///This script will handle data universal among the 4 players
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 19-Mar-2019
///Dependencies: The four notespawners MUST have the NoteSpawner tag to change their song output
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    public static GameDataManager gcInstance;

    public bool voteInProgress;//Bool that tracks if vote is ongoing
    public int currentVote, totalVotes;//Vote count, and total votes sent in
    public int aiCount;//How many AI there are active
    int currentSongID, newSongID;
    GameObject[] noteSpawners;//The 4 note spawners


    //This awake method ensures only one game manager is active at one time, if there is a second the original stays
    private void Awake()
    {
        if (gcInstance == null)
        {
            gcInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        Application.targetFrameRate = 30;//Max framerate is 30 to prevent weird issues with notes
        voteInProgress = false;
        currentVote = 0;
        aiCount = 4;
        currentSongID = 0;
        newSongID = -1;
        noteSpawners = GameObject.FindGameObjectsWithTag("NoteSpawner");
    }
    void Update()
    {
        
        if (aiCount != 4)//If there is at least one real player available to vote
        {
            if (currentVote == (4 - aiCount))//If everyone agrees, AI doesnt vote so lower needed score in case of AI activeness
            {
                //VOTE PASSED
                foreach (GameObject noteSpawner in noteSpawners)//For the 4 note spawners
                {
                    noteSpawner.GetComponent<NoteSpawning>().PlayNewSong(newSongID);//Set the song choice, reset the beat, and set the bpm and time signature to the songs
                    noteSpawner.GetComponent<NoteSpawning>().ResetHoldNotes();
                    SetCurrentSongID(newSongID);
                }
                ResetVote();
            }
            else if (totalVotes == (4 - aiCount))//If all players have voted and failed, reset
            {
                ResetVote();
            }
        }
    }

    public void IncrementVote(int vote)//Simply increments the vote based on the players vote choice
    {
        //1 = yes
        //-1 = nos
        currentVote += vote;//If all say yes then the current vote will be 4 unless there is AI active
        totalVotes++;
    }

    public void SetNewSongID(int songID)
    {
        newSongID = songID;
    }

    public void SetCurrentSongID(int songID)
    {
        currentSongID = songID;
    }
    public int GetCurrentSongID()
    {
        return currentSongID;
    }

    public string GetSongName()
    {
        return noteSpawners[0].GetComponent<NoteSpawning>().songs[newSongID].GetSongName();
    }

    public void ResetVote()
    {
        voteInProgress = false;
        currentVote = 0;
        totalVotes = 0;
        newSongID = currentSongID;
    }

    //This tracks the AI count, it is not very clean however
    public void SetAICount(int aiCounter)
    {
        //1 = ai on
        //-1 = ai off
        aiCount += aiCounter;
    }
}
