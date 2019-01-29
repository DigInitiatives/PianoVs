///Author: Noah Rittenhouse
///Purpose of Script: Script for simple homemade button
/// This script is meant to be a recreation of Unity's button with direct touch controls implemented rather than what unity has pre-made
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 28-Jan-2019
///Dependencies: Text display and homemade button selected through editor
///
using UnityEngine;

public class MyButtonScript : MonoBehaviour
{
    [SerializeField]
    GameObject displayText;
    Rect rectasd;
    Canvas can;
    RectTransform rect;

    float x, y;

    bool isActive, reset;

    protected void Start()
    {
        isActive = false;//Text starts disabled

        #region Rectangle creation(basically just defines the rectangle bounds
        rect = this.GetComponent<RectTransform>();
        can = GameObject.Find("Canvas").GetComponent<Canvas>();
        rectasd = new Rect(rect.position, rect.rect.size * can.GetComponent<RectTransform>().localScale.x);
        rectasd.center = rect.position;
        #endregion

    }
    protected void Update()
    {
        displayText.SetActive(isActive);//Turns display on or off

        foreach (Touch touch in Input.touches)
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (rectasd.Contains(touchPos) && reset)
            {
                SetTextActive();
                reset = true;
            }
            else
            {
                reset = false;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (rectasd.Contains(mousePos))
            {
                SetTextActive();
            }
        }
    }

    /// <summary>
    /// Toggles bool that controls the text display
    /// </summary>  
    public void SetTextActive()
    {
        isActive = !isActive;
    }

}
