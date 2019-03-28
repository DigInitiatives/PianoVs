///Author: Noah Rittenhouse
///This script will be attached to each of the keyboard prefabs and will handle any and all player data, score/AI bool, etc
///Last Modified By: Noah Rittenhouse
///Last Modified Date: Mar-21-2019
///Dependencies: Score displays must be assigned in the editor
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDataManager : MonoBehaviour
{
    GameDataManager gcInstance;
    public bool isPlayer3Or4, isRecording, isAI;

    float playerScore, playerMultiplier;//Ints that hold the players score and multiplier
    float holdingScore;//Float that holds score from holding note so it can be rounded for the display
    float sleepTimer;
    float multiplierCount;//Variable that keeps track of how many good hits the player has gotten so far
    [SerializeField]
    int comboCount;//Variable that keeps track of how many good hits the player needs    

    GameObject playerHud;
    public Text playerScoreDisplay;
    public Image playerMultiplierBar;
    void Start()
    {
        gcInstance = GameDataManager.gcInstance;
        playerScore = 0;
        holdingScore = 0;
        sleepTimer = Time.time;//Seconds until AI takes over
        multiplierCount = 0;
        playerMultiplier = 1;
        isAI = true;
        isRecording = false;
        if (isPlayer3Or4)
        {
            foreach (IndividualKeyScript keyScript in transform.GetComponentsInChildren<IndividualKeyScript>())
            {
                keyScript.player3or4 = true;
            }
        }
        else
        {
            foreach (IndividualKeyScript keyScript in transform.GetComponentsInChildren<IndividualKeyScript>())
            {
                keyScript.player3or4 = false;
            }
        }
        if (comboCount <= 0)
        {
            comboCount = 1;//Defaults to 10 good hits needed
        }
        #region Set KeyNumbers
        int keyNum = 0;
        foreach (GameObject key in GameObject.FindGameObjectsWithTag("Key"))
        {
            key.GetComponent<IndividualKeyScript>().keyNum = keyNum;
            keyNum++;
            if (keyNum == 49)
            {
                keyNum = 0;
            }
        }

        #endregion
        try
        {
            playerHud = GameObject.FindGameObjectWithTag(name);
        }
        catch { }
    }

    void Update()
    {
        try
        {
            playerScoreDisplay.text = "Score:\n" + Mathf.RoundToInt(playerScore + holdingScore) + "\n" + "Multiplier:\n" + playerMultiplier;
            playerMultiplierBar.fillAmount = multiplierCount;
            if (playerMultiplier == 8)
            {
                playerMultiplierBar.fillAmount = 1;
            }
        }
        catch { }
        if (isRecording)
        {
            SongRecording.SongPlaying();
        }
        if (sleepTimer + 30 < Time.time)
        {
            ResetSleepTime();
            SetAI(true);
        }
    }

    #region Score handling
    public void AddScore(float scoreToAdd)//This method is called when a note is hit by the player and simply adds an amount decided by how timely they hit it
    {
        playerScore += scoreToAdd * playerMultiplier;
    }
    public void AddHoldingScore(float scoreToAdd)
    {
        holdingScore += scoreToAdd;
    }
    public void IncreaseMultiplier(float amount)//Increases multiplier every time they get a good hit
    {
        if (playerMultiplier < 8)
        {
            multiplierCount += amount;//Add 'score' to multiplierCount
            if (multiplierCount >= comboCount + 0.1f)//If the multiplierCount is more than the previously specified amount of 'score' needed to increase mulitplier
            {
                multiplierCount = 0;//Reset multiplierCount
                playerMultiplier++;//Increase player multiplier
            }
        }
    }
    public void BreakMultiplier()//Reset the multiplier variables if the player messes up
    {
        multiplierCount = 0;
        playerMultiplier = 1;
    }
    #endregion
    #region Recording
    public void ToggleRecording()
    {
        isRecording = !isRecording;
        if (isRecording)
        {
            foreach (IndividualKeyScript keyScript in transform.GetComponentsInChildren<IndividualKeyScript>())
            {
                keyScript.songrecording = true;
            }
        }
        else
        {
            foreach (IndividualKeyScript keyScript in transform.GetComponentsInChildren<IndividualKeyScript>())
            {
                keyScript.songrecording = false;
            }
        }
    }
    #endregion


    public void SetAI(bool on)//Set AI as on or off
    {
        if (on && isAI == false)
        {
            isAI = true;
            gcInstance.SetAICount(1);
            foreach (IndividualKeyScript keyScript in transform.GetComponentsInChildren<IndividualKeyScript>())
            {
                keyScript.AI = true;
                keyScript.StopNote();
                keyScript.gameObject.GetComponent<AudioSource>().volume = 0.5f;
            }
        }
        else if (!on && isAI == true)
        {
            isAI = false;
            gcInstance.SetAICount(-1);
            foreach (IndividualKeyScript keyScript in transform.GetComponentsInChildren<IndividualKeyScript>())
            {
                keyScript.AI = false;
                keyScript.StopNote();
                keyScript.gameObject.GetComponent<AudioSource>().volume = 1f;
            }
        }
    }
    public void ResetSleepTime()
    {
        SetAI(false);//Turn off AI
        sleepTimer = Time.time;//Reset sleep timer
    }
}
