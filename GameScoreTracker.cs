///Author: Noah Rittenhouse
///Purpose of Script: Detect when a note is hit and how far
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 31-Jan-2019
///Dependencies: Text scoreDisplay is determined in editor

using UnityEngine;
using UnityEngine.UI;

public class GameScoreTracker : MonoBehaviour
{
    static int[] scores;
    static int currentMultiplier, multiplierCount;

    [SerializeField]
    Text scoreDisplay;

    void Start()
    {
        currentMultiplier = 1;
        scores = new int[3];
    }


    void Update()
    {
        scoreDisplay.text = scores[0].ToString();//Display score
    }

    public static void AddScore(int score, int player)
    {
        score = score * currentMultiplier;
        scores[player] += score;
    }
    public static void IncreaseMultiplier(int amount)//Increases multiplier 
    {
        multiplierCount += amount;
        if(multiplierCount >= 10)
        {
            multiplierCount = 0;
            currentMultiplier++;
        }
    }
    public static void BreakMultiplier()
    {
        currentMultiplier = 1;
    }
}
