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
        //for (int i = 0; i < 80; i++)
        //{
        //    hitObj.Add(new GameObject());
        //}
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
            ray = Camera.main.ScreenPointToRay(touch.position);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    //Raycast from the touch on the screen position to the world position
                    if (Physics.Raycast(ray, out hit))
                    {

                        //check if that touch index is currently pressing a note. 
                        // This is to prevent a very strange in which a touch index would began again without ending therefore its note would keep playing even if not touched
                        //if the raycast hits a collider whose game object has the tag "Note"
                        
                        if (hit.collider.gameObject.tag == "Key" && !hitObj.Contains(hit.collider.gameObject))
                        {

                            hitObj.Add(hit.collider.gameObject);
                            //Debug.Log("Touch");
                            //Call the PlayNote() method in this objects NoteObjScript
                            hit.collider.gameObject.GetComponent<IndividualKeyScript>().PlayNote();
                        }
                    }

                    Debug.Log("Touch: " + touchIndex + " Started");
                    break;
                case TouchPhase.Moved:
                    break;
                case TouchPhase.Ended:

                    if (hitObj[touchIndex].gameObject.GetComponent<IndividualKeyScript>() != null)
                    {
                        hitObj[touchIndex].gameObject.GetComponent<IndividualKeyScript>().StopNote(); //error
                    }
                    hitObj.Remove(hitObj[touchIndex]);

                    Debug.Log("Touch: " + touchIndex + " Ended");
                    break;
                default:
                    break;
            }

            //increments the touch index
            touchIndex += 1;
        }

        if (Input.touches.Length <= 0)
        {
            for (int i = 0; i < hitObj.Count; i++)
            {
                if (hitObj[i].GetComponent<IndividualKeyScript>() != null)
                {
                    hitObj[i].gameObject.GetComponent<IndividualKeyScript>().StopNote();
                    hitObj.Remove(hitObj[i]);
                }
            }
        }
    }
}
