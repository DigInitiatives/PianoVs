using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    static int currentVote;//Vote count
    static int aiCount;//How many AI there are active
    static int currentSongID;
    void Start()
    {
        currentVote = 0;
        aiCount = 0;
        currentSongID = 0;
    }
    void Update()
    {
        
    }

    public static void IncrementVote(int vote)
    {
        //1 = yes
        //-1 = no
        currentVote += vote;
    }
}
