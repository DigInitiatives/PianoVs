using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VotingHandler : MonoBehaviour
{
    static int currentVote;

    void Start()
    {
        currentVote = 0;
    }
    void Update()
    {
        Debug.Log(currentVote);
    }

    public static void IncrementVote(int vote)
    {
        //1 = yes
        //-1 = no
        currentVote += vote;
    }
}
