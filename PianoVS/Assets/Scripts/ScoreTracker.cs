using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{

    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void HalfHit()
    {
        score = score + 50;
        Debug.Log(score);
    }

    public static void PerfectHit()
    {
        score = score + 100;
        Debug.Log(score);
    }

}
