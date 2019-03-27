using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScale : MonoBehaviour
{
    public float scaleFactor;
    void Update()
    {
        Time.timeScale = scaleFactor;
    }
}