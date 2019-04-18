///Author: Noah Rittenhouse
///This script will handle all the menu button presses and what they do
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 19-Mar-2019
///Dependencies: Note spawners must be assigned in inspector
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMenuHandler : MonoBehaviour
{
    GameDataManager gcInstance;

    bool doOnce;//Bool just for a fake start method to only play once
    bool menuStatus, toggleTimerStatus, votingPanelStatus, waitingMessageStatus, voted;
    float toggleTimer;
    int currentSongID;

    [SerializeField]
    GameObject menuPanel, menuToggleText, dropdownMenu, votingText, votePanel, waitingMessage, playersKeyboard, freeplayDisplay;
    [SerializeField]
    GameObject noteSpawner;
    string songName;
    List<string> songNames;

    void Start()
    {
        gcInstance = GameDataManager.gcInstance;

        songName = "default";
        menuStatus = false;
        toggleTimerStatus = false;
        votingPanelStatus = false;
        waitingMessageStatus = false;
        voted = false;
        toggleTimer = 0.0f;
        doOnce = true;

        songNames = new List<string>();

        menuToggleText.transform.localScale = new Vector3(menuToggleText.transform.localScale.x, 0);
    }
    void Update()
    {
        //This is basically a manual start, but it goes after every other start method so that the songs are loaded before we try to set the dropdown list
        if (doOnce)//Do once...clear dropdown, and for every song add that songs name to the dropdown list
        {
            dropdownMenu.GetComponent<Dropdown>().ClearOptions();//Clear what is in the dropdown by default

            for (int i = 0; i < noteSpawner.GetComponent<NoteSpawning>().songs.Count - 1; i++)//For every song, but we minus one so the Recorded Song is not shown
            {
                songNames.Add(noteSpawner.GetComponent<NoteSpawning>().songs[i].GetSongName());//Get the song name and add it to a list
            }
            dropdownMenu.GetComponent<Dropdown>().AddOptions(songNames);//Put all the song names into the list
            doOnce = false;
        }
        currentSongID = gcInstance.GetCurrentSongID();
        menuPanel.SetActive(menuStatus);//Either enable or disable the menu
        waitingMessage.SetActive(waitingMessageStatus);//Enable or disable the message that indicates the stage of the vote
        votePanel.SetActive(votingPanelStatus);//Enable or disable the voting panel
        dropdownMenu.GetComponent<Dropdown>().value = currentSongID;

        if(currentSongID == 0)//Song 0 is always freeplay mode, which can be chosen or is chosen automatically once a song finishes
        {
            freeplayDisplay.SetActive(true);//Display the freeplay panel
        }
        else
        {
            freeplayDisplay.SetActive(false);//Close the freeplay panel if any other song is playing
        }

        //These two if statements control the menu opening, we use a timer based holding setup so the menu can't be spammed by some annoying child
        if (toggleTimerStatus && toggleTimer < 0.5f)//if they are holding the button decrement the timer variable
        {
            toggleTimer += Time.deltaTime;
            menuToggleText.transform.localScale = new Vector3(menuToggleText.transform.localScale.x, toggleTimer / 0.5f);
        }
        if (toggleTimer >= 0.5f)//If they hold the button for half a second open the menu!
        {
            menuStatus = true;//Open menu
            menuToggleText.transform.localScale = new Vector3(menuToggleText.transform.localScale.x, toggleTimer / 0.5f);
        }

        if (gcInstance.voteInProgress && !voted)//If there is a vote occurring and you havent voted yet make sure the menu is on
        {
            VotingActive();
        }
        else if (!gcInstance.voteInProgress)//If there is no vote disable shit
        {
            VotingInactive();
        }
    }

    #region Menu Activation
    //These are called using the Unity event system and are tied directly to the menu buttons
    public void PressedMenuToggle()//When the player presses the menu button begin a timer, or if the menu is already open then just close it
    {
        if (!menuStatus)
        {
            playersKeyboard.GetComponent<PlayerDataManager>().ResetSleepTime();
            toggleTimerStatus = true;//Start timer
        }
        else
        {
            menuStatus = false;//Close menu
            menuToggleText.transform.localScale = new Vector3(menuToggleText.transform.localScale.x, toggleTimer / 0.5f);
        }
    }
    public void StoppedPressingMenuToggle()//Once the player lets go of the button, if they pressed it for over a second, turn the menu on
    {
        toggleTimerStatus = false;//Stop timer
        if (toggleTimer >= 0.5f)
        {
            menuStatus = true;//Open menu
        }
        toggleTimer = 0.0f;//Reset timer
        menuToggleText.transform.localScale = new Vector3(menuToggleText.transform.localScale.x, toggleTimer / 0.5f);
    }
    #endregion

    public void QuitGame()
    {
        Application.Quit();
    }
    #region Song Selection
    public void SelectSong()
    {
        if (!gcInstance.voteInProgress)//If there is not already a vote going on...
        {
            int songID = dropdownMenu.GetComponent<Dropdown>().value;//Set the players choice as the songID
            if (songID != currentSongID)//if the players choice is not already playing...
            {
                gcInstance.voteInProgress = true;//Let the game know there is now a vote active
                gcInstance.SetNewSongID(songID);//Let the game know the ID of the voted song
                VotingActive();
            }
        }
    }

    //This rather messy but functional voting system sends either a 1 or -1 to the game manager which through simple math determines how many said yes
    // The game manager then compares the current vote score against how many AI are active, if 3 AI are active only a score of 1 is needed, so one yes
    public void SubmitVote(bool vote)
    {
        //true = yes
        //false = no
        if (vote)//Yes
        {
            gcInstance.IncrementVote(1);
        }
        else//No
        {
            gcInstance.IncrementVote(-1);
        }
        menuStatus = false;//Close menu
        voted = true;//They have voted
        waitingMessageStatus = true;//Open message
        votingPanelStatus = false;//Close panel
    }

    public void VotingActive()//Open the yes or no panel and disable the dropdown
    {
        votingText.GetComponent<Text>().text = "Switch to " + gcInstance.GetSongName();
        votingPanelStatus = true;
        dropdownMenu.GetComponent<Dropdown>().interactable = false;
    }
    public void VotingInactive()//Close the yes or no panel and set the dropdown to usable
    {
        dropdownMenu.GetComponent<Dropdown>().interactable = true;
        waitingMessageStatus = false;//Closes message
        voted = false;
    }
    #endregion
}
