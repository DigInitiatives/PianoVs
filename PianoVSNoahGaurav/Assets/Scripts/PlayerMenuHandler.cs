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
    bool menuStatus, toggleTimerStatus;
    float toggleTimer;
    [SerializeField]
    GameObject menuPanel, menuToggleText;

    void Start()
    {
        menuStatus = false;
        toggleTimerStatus = false;
        toggleTimer = 1;
    }
    void Update()
    {
        menuPanel.SetActive(menuStatus);//Either enable or disable the menu
        if (toggleTimerStatus)//if they are holding the button decrement the timer variable
        {
            toggleTimer -= Time.deltaTime;
        }
        menuToggleText.GetComponent<Text>().text = toggleTimer.ToString();//Just a display that shows how long they have pressed
    }

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
        toggleTimer = 1;//Reset timer
    }
}
