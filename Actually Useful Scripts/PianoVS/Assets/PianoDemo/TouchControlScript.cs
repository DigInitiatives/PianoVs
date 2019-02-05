using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControlScript : MonoBehaviour
{
    /*
    * Summary:
    * This script is attatched to the main camera of the scene. The purpose of this script is to take in touch input, and recognize if the touch was on a key (can be easily modified for other objects)
    * Date: 31/01/2019
    * Author: Adam Warkentin
    * Dependencies: Keys need to have the tag "Key"
    */

    //List to track what game object each touch index has touched
    List<GameObject> hitObj;

    // Use this for initialization
    void Start()
    {
        hitObj = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        //Index to track the touch index in Input.touches
        int touchIndex = 0;

        //Loops through each instance of touch input
        foreach (Touch touch in Input.touches)
        {
            RaycastHit hit;
            Ray ray;

            //if the touch just started
            if (touch.phase == TouchPhase.Began)
            {
                //Raycast from the touch on the screen position to the world position
                ray = Camera.main.ScreenPointToRay(touch.position); 
                if (Physics.Raycast(ray,out hit))
                {
                    //Add the object hit to the list, at the index of the touch
                    hitObj.Add(hit.collider.gameObject);

                    //if the raycast hits a collider whose game object has the tag "Note"
                    if (hit.collider.gameObject.tag == "Key")
                    {
                        Debug.Log("Touch");
                        //Call the PlayNote() method in this objects NoteObjScript
                        hit.collider.gameObject.GetComponent<IndividualKeyScript>().PlayNote();
                    }
                }
            }

            if (touch.phase == TouchPhase.Ended)
            {
                //if this touch has ended, call the stopnote method of the object it was touching and remove it from the obj list at the index of the touch
                hitObj[touchIndex].GetComponent<IndividualKeyScript>().StopNote();
                hitObj.Remove(hitObj[touchIndex]);
            }

            //increments the touch index
            touchIndex += 1;
        }
    }
}
