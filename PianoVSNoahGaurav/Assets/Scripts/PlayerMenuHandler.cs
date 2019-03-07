///Author: Noah Rittenhouse
///This script will handle all the menu button presses and what they do
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 5-Mar-2019
///Dependencies: 
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMenuHandler : MonoBehaviour
{
    bool menuStatus, toggleTimerStatus, votingPanelStatus, waitingMessageStatus;
    float toggleTimer;
    int currentSongID, songToVoteFor;
    [SerializeField]
    GameObject menuPanel, menuToggleText;
    [SerializeField]
    GameObject dropdownMenu, votingText, votePanel, waitingMessage;
    string songName;
    void Start()
    {
        songName = "default";
        songToVoteFor = -1;
        menuStatus = false;
        toggleTimerStatus = false;
        votingPanelStatus = false;
        waitingMessageStatus = false;
        toggleTimer = 0.5f;
    }
    void Update()
    {
        menuPanel.SetActive(menuStatus);//Either enable or disable the menu
        waitingMessage.SetActive(waitingMessageStatus);
        votePanel.SetActive(votingPanelStatus);//Close vote panel
        if (toggleTimerStatus)//if they are holding the button decrement the timer variable
        {
            toggleTimer -= Time.deltaTime;
        }
        menuToggleText.GetComponent<Text>().text = toggleTimer.ToString();//Just a display that shows how long they have pressed
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
        }
    }
    public void StoppedPressingMenuToggle()//Once the player lets go of the button, if they pressed it for over a second, turn the menu on
    {
        toggleTimerStatus = false;//Stop timer
        if (toggleTimer <= 0)
        {
            menuStatus = true;//Open menu
        }
        toggleTimer = 0.5f;//Reset timer
    }
    #endregion

    #region Difficulty Selection

    #endregion

    #region Song Selection
    public void SelectSong()
    {
        int songID = dropdownMenu.GetComponent<Dropdown>().value;
        if(songID != currentSongID)
        {
            songToVoteFor = songID;
            //
            //Find song data from songID, database required
            //
            votingText.GetComponent<Text>().text = "Switch to " + songName;
            //
            //Send song to vote for to other players
            //
            votingPanelStatus = true;
            dropdownMenu.GetComponent<Dropdown>().interactable = false;
        }
    }

    public void SubmitVote(bool vote)
    {
        //true = yes
        //false = no
        if(vote)//Yes
        {
            GameDataManager.IncrementVote(1);
        }
        else//No
        {
            GameDataManager.IncrementVote(-1);
        }
        waitingMessageStatus = true;//Open message
        votingPanelStatus = false;//Close panel
    }
    #endregion
}
