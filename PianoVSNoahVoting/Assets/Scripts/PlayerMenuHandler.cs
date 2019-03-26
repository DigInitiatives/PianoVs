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

    GameObject menuPanel, menuToggleText;
    GameObject dropdownMenu, votingText, votePanel, waitingMessage;
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
        //Find children assets
        menuPanel = transform.Find("MenuPanel").gameObject;
        menuToggleText = transform.Find("MenuToggle/Countdown").gameObject;
        dropdownMenu = transform.Find("MenuPanel/SongVoting/Dropdown").gameObject;
        votingText = transform.Find("MenuPanel/SongVoting/VotePanel/VoteText").gameObject;
        votePanel = transform.Find("MenuPanel/SongVoting/VotePanel").gameObject;
        waitingMessage = transform.Find("MenuPanel/SongVoting/WaitingMessage").gameObject;
        //
        menuToggleText.transform.localScale = new Vector3(menuToggleText.transform.localScale.x, 0);
    }
    void Update()
    {
        if (doOnce)//Do once...clear dropdown, and for every song add that songs name to the dropdown list
        {
            dropdownMenu.GetComponent<Dropdown>().ClearOptions();

            for (int i = 0; i < noteSpawner.GetComponent<NoteSpawning>().songs.Count - 1; i++)
            {
                songNames.Add(noteSpawner.GetComponent<NoteSpawning>().songs[i].GetSongName());
            }
            dropdownMenu.GetComponent<Dropdown>().AddOptions(songNames);
            doOnce = false;
        }


        currentSongID = gcInstance.GetCurrentSongID();
        menuPanel.SetActive(menuStatus);//Either enable or disable the menu
        waitingMessage.SetActive(waitingMessageStatus);//Enable or disable the message that indicates the stage of the vote
        votePanel.SetActive(votingPanelStatus);//Enable or disable the voting panel
        dropdownMenu.GetComponent<Dropdown>().value = currentSongID;


        if (toggleTimerStatus && toggleTimer < 0.5f)//if they are holding the button decrement the timer variable
        {
            toggleTimer += Time.deltaTime;
            menuToggleText.transform.localScale = new Vector3(menuToggleText.transform.localScale.x, toggleTimer / 0.5f);
        }
        if (toggleTimer >= 0.5f)
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
    public void PressedMenuToggle()//When the player presses the menu button begin a timer, or if the menu is already open then just close it
    {
        if (!menuStatus)
        {
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

    #region Difficulty Selection

    #endregion


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

    public void VotingActive()
    {
        votingText.GetComponent<Text>().text = "Switch to " + gcInstance.GetSongName();
        votingPanelStatus = true;
        dropdownMenu.GetComponent<Dropdown>().interactable = false;
    }
    public void VotingInactive()
    {
        dropdownMenu.GetComponent<Dropdown>().interactable = true;
        waitingMessageStatus = false;//Closes message
        voted = false;
    }
    #endregion
}
