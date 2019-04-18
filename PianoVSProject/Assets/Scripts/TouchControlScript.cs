///Author: Adam Warkentin
///This script is attatched to the main camera of the scene. The purpose of this script is to take in touch input, and recognize if the touch was on a key (can be easily modified for other objects)
///Last Modified By: Adam Warkentin
///Last Modified Date: 18-April-2019
///Dependencies: Keys need to have the tag "Key"
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControlScript : MonoBehaviour
{
    //List to track what game object each touch index has touched
    [SerializeField]
    List<GameObject> hitObj;

    void Start()
    {
        //Disables the mouse functionality. This was done due to contasnt interference from unintended "right-clicks"
        Input.simulateMouseWithTouches = false;

        hitObj = new List<GameObject>();
        //populates the list with empty game objects. This is done because, if the list was only populated by objects when they were touched, the touches would desynced
        for (int i = 0; i < 160; i++)
        {
            hitObj.Add(new GameObject());
        }
    }

    void FixedUpdate()
    {
        //Loops through each instance of touch input
        foreach(Touch touch in Input.touches)
        {
            //Raycast from touch
            RaycastHit hit;
            Ray ray;
            ray = Camera.main.ScreenPointToRay(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    //Determines if the object hit by the raycast is a "key"
                    if(Physics.Raycast(ray, out hit))
                    {
                        if (hitObj[touch.fingerId].GetComponent<IndividualKeyScript>() != null && hit.collider.gameObject.tag == "Key" && !hitObj.Contains(hit.collider.gameObject))
                        {
                            //Adds the key to the list of hit objects at the index of the touch
                            hitObj[touch.fingerId] = hit.collider.gameObject;
                            //Plays key
                            hitObj[touch.fingerId].GetComponent<IndividualKeyScript>().PlayNote(false);
                        }
                    }
                    break;
                case TouchPhase.Moved:
                    //Checks if the raycast is still hitting a key, and if so, is it a different key
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider.gameObject.tag == "Key" && !hitObj.Contains(hit.collider.gameObject))
                        {
                            if (hitObj[touch.fingerId].GetComponent<IndividualKeyScript>() != null)
                            {
                                //stops the note from playing
                                hitObj[touch.fingerId].GetComponent<IndividualKeyScript>().StopNote();
                            }
                            //Adds the key to the list of hit objects at the index of the touch
                            hitObj[touch.fingerId] = hit.collider.gameObject;
                            //Plays key
                            hitObj[touch.fingerId].GetComponent<IndividualKeyScript>().PlayNote(false);
                        }
                        else if(hit.collider.gameObject.GetComponent<IndividualKeyScript>() == null)
                        {
                            if (hitObj[touch.fingerId].GetComponent<IndividualKeyScript>() != null)
                            {
                                //stops the note from playing
                                hitObj[touch.fingerId].GetComponent<IndividualKeyScript>().StopNote();
                            }
                            //clears the object associated with the touch index in the list of hit objects
                            hitObj[touch.fingerId] = new GameObject();
                        }
                    }
                    break;
                case TouchPhase.Stationary:
                    break;
                case TouchPhase.Ended:
                    //stops the note from being played once the touch has ended
                    if(hitObj[touch.fingerId].GetComponent<IndividualKeyScript>() != null)
                    {
                        //stops the note from playing
                        hitObj[touch.fingerId].GetComponent<IndividualKeyScript>().StopNote();
                        hitObj[touch.fingerId] = new GameObject();
                    }
                    break;
                case TouchPhase.Canceled:
                    break;
                default:
                    break;
            }
        }
    }
}
