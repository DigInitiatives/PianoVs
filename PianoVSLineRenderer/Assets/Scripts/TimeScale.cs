using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScale : MonoBehaviour
{
    public float scaleFactor;

    void Update()
    {
        Time.timeScale = scaleFactor;
    }
}


///Hot garbage