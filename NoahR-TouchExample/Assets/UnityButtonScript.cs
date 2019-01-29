///Author: Noah Rittenhouse
///Purpose of Script: Script for simple Unity button
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 28-Jan-2019
///Dependencies: Text display selected through editor

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityButtonScript : MonoBehaviour
{
    [SerializeField]
    GameObject displayText;
    bool isActive;

    protected void Start()
    {
        isActive = false;//Text starts disabled
    }
    protected void Update()
    {
        displayText.SetActive(isActive);//Turns display on or off
    }

    /// <summary>
    /// Toggles bool that controls the text display
    /// </summary>  
    public void SetTextActive() 
    {
        isActive = !isActive;
    }

}
