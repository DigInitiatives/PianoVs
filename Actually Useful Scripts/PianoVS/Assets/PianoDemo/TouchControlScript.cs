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
    [SerializeField]
    List<GameObject> hitObj;

    // Use this for initialization
    void Start()
    {
        hitObj = new List<GameObject>();

        for(int i = 0; i < 80; i++)
        {
            hitObj.Add(new GameObject());
        }
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
                    hitObj[touchIndex] = hit.collider.gameObject;

                    //if the raycast hits a collider whose game object has the tag "Note"
                    if (hit.collider.gameObject.tag == "Key")
                    {
                        //Debug.Log("Touch");
                        //Call the PlayNote() method in this objects NoteObjScript
                        hit.collider.gameObject.GetComponent<IndividualKeyScript>().PlayNote();
                    }
                }
            }
            if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("moved");
                //Raycast from the touch on the screen position to the world position
                ray = Camera.main.ScreenPointToRay(touch.position);
                if (!Physics.Raycast(ray))
                {
                    if (hitObj[touchIndex].gameObject.GetComponent<IndividualKeyScript>() != null)
                    {
                        hitObj[touchIndex].gameObject.GetComponent<IndividualKeyScript>().StopNote(); //error
                        hitObj[touchIndex] = new GameObject();
                    }
                }
                //if (Physics.Raycast(ray, out hit))
                //{
                //    if (hit.collider.gameObject != hitObj[touchIndex])
                //    {
                //        hitObj[touchIndex].GetComponent<IndividualKeyScript>().StopNote();
                //        if (!hitObj.Contains(hit.collider.gameObject))
                //        {
                //            hitObj[touchIndex] = hit.collider.gameObject;
                //            hit.collider.gameObject.GetComponent<IndividualKeyScript>().PlayNote();
                //        }
                //        else
                //        {
                //            hitObj[touchIndex].GetComponent<IndividualKeyScript>().StopNote();
                //            hitObj[touchIndex] = new GameObject();
                //        }
                //    }
                //}
            }
            if (touch.phase == TouchPhase.Ended)
            {
                //if this touch has ended, call the stopnote method of the object it was touching and remove it from the obj list at the index of the touch
                if (hitObj[touchIndex].gameObject.GetComponent<IndividualKeyScript>() != null)
                {
                    hitObj[touchIndex].gameObject.GetComponent<IndividualKeyScript>().StopNote(); //error
                    hitObj[touchIndex] = new GameObject();
                }
            }

            //increments the touch index
            touchIndex += 1;
        }

        if (Input.touches.Length <= 0)
        {
            for(int i = 0; i < hitObj.Count; i++)
            {
                if (hitObj[i].GetComponent<IndividualKeyScript>() != null)
                {
                    hitObj[i].GetComponent<IndividualKeyScript>().StopNote();
                    hitObj[i] = new GameObject();
                }
            }
        }
    }
}
