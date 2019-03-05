using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
///Author: Noah Rittenhouse
///This script will be attached to each of the keyboard prefabs and will handle any and all player data, score/AI bool, etc
///Last Modified By: Noah Rittenhouse
///Last Modified Date: Feb-14-2019
///Dependencies: Score displays must be assigned in the editor

public class PlayerDataManager : MonoBehaviour
{
    bool isAI;//Bool that controls whether or not the AI is active

    float playerScore, playerMultiplier;//Ints that hold the players score and multiplier
    float holdingScore;//Float that holds score from holding note so it can be rounded for the display
    int multiplierCount;//Variable that keeps track of how many good hits the player has gotten so far
    [SerializeField]
    int comboCount;//Variable that keeps track of how many good hits the player needs    

    [SerializeField]
    Text playerScoreDisplay;

    void Start()
    {
        playerScore = 0;
        holdingScore = 0;

        multiplierCount = 0;
        playerMultiplier = 1;

        isAI = true;

        if(comboCount == 0)
        {
            comboCount = 10;//Defaults to 10 good hits needed
        }
    }

    void Update()
    {
        playerScoreDisplay.text = "Score " + Mathf.RoundToInt(playerScore + holdingScore) + "\n" + "Multiplier " + playerMultiplier;

        if(isAI)
        {
            //Turn AI on? Maybe have a method that is called when the keyboard area is touched?
        }
        
        
    }

    public void AddScore(float scoreToAdd)//This method is called when a note is hit by the player and simply adds an amount decided by how timely they hit it
    {
        playerScore += scoreToAdd * playerMultiplier;
    }
    public void AddHoldingScore(float scoreToAdd)
    {
        holdingScore += scoreToAdd;
    }
    public void IncreaseMultiplier(int amount)//Increases multiplier every time they get a good hit
    {
        if (playerMultiplier < 8)
        {
            multiplierCount += amount;
            if (multiplierCount >= comboCount)
            {
                multiplierCount = 0;
                playerMultiplier++;
            }
        }
    }
    public void BreakMultiplier()//Reset the multiplier variables if the player messes up
    {
        multiplierCount = 0;
        playerMultiplier = 1;
    }
}
