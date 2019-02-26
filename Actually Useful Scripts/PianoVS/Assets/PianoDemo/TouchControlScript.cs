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
        for (int i = 0; i < 80; i++)
        {
            hitObj.Add(new GameObject());
        }
    }

    // Update is called once per frame
    void Update()
    {
        #region Ver1
        ////Index to track the touch index in Input.touches
        //Touch[] touches = Input.touches;
        ////Loops through each instance of touch input
        //for(int i = 0; i < Input.touchCount; i++)
        //{
        //    RaycastHit hit;
        //    Ray ray;
        //    ray = Camera.main.ScreenPointToRay(touches[i].position);
        //    switch (touches[i].phase)
        //    {
        //        case TouchPhase.Began:
        //            //Raycast from the touch on the screen position to the world position
        //            if (Physics.Raycast(ray, out hit))
        //            {

        //                //check if that touch index is currently pressing a note. 
        //                // This is to prevent a very strange in which a touch index would began again without ending therefore its note would keep playing even if not touched
        //                //if the raycast hits a collider whose game object has the tag "Note"

        //                if (hit.collider.gameObject.tag == "Key" && !hitObj.Contains(hit.collider.gameObject) && touches[i].phase != TouchPhase.Ended /*(Input.touchCount >= hitObj.Count)*/)
        //                {

        //                    hitObj.Add(hit.collider.gameObject);
        //                    //Debug.Log("Touch");
        //                    //Call the PlayNote() method in this objects NoteObjScript
        //                    hit.collider.gameObject.GetComponent<IndividualKeyScript>().PlayNote();
        //                }
        //            }

        //            //Debug.Log("Touch: " + i + " Started");
        //            Debug.Log("Touch: " + i + " Position:" + Camera.main.ScreenPointToRay(touches[i].position));
        //            break;
        //        case TouchPhase.Moved:
        //            break;
        //        case TouchPhase.Ended:

        //            if (hitObj[i].gameObject.GetComponent<IndividualKeyScript>() != null)
        //            {
        //                hitObj[i].gameObject.GetComponent<IndividualKeyScript>().StopNote(); //error
        //            }
        //            hitObj.Remove(hitObj[i]);

        //            Debug.Log("Touch: " + i + " Ended");
        //            break;
        //        default:
        //            break;
        //    }

        //    //if (touches[i].deltaPosition.x > 20.0f || touches[i].deltaPosition.y > 20.0f)
        //    //{
        //    //    touches[i].phase = TouchPhase.Canceled;

        //    //    if (hitObj[i].gameObject.GetComponent<IndividualKeyScript>() != null)
        //    //    {
        //    //        hitObj[i].gameObject.GetComponent<IndividualKeyScript>().StopNote(); //error
        //    //    }
        //    //    hitObj.Remove(hitObj[i]);
        //    //}
        //    if (Camera.main.ScreenPointToRay(touches[i].position).origin.x > hitObj[i].transform.position.x + 1.5f 
        //        || Camera.main.ScreenPointToRay(touches[i].position).origin.x < hitObj[i].transform.position.x - 1.5f)
        //    {
        //        touches[i].phase = TouchPhase.Canceled;

        //        if (hitObj[i].gameObject.GetComponent<IndividualKeyScript>() != null)
        //        {
        //            hitObj[i].gameObject.GetComponent<IndividualKeyScript>().StopNote(); //error
        //        }
        //        hitObj.Remove(hitObj[i]);
        //    }

        //}

        ////if(hitObj.Count > 0)
        ////{
        ////    for(int i = 0; i < hitObj.Count; i++)
        ////    {
        ////        if(i + 1 > Input.touchCount)
        ////        {
        ////            if (hitObj[i].gameObject.GetComponent<IndividualKeyScript>() != null)
        ////            {
        ////                hitObj[i].gameObject.GetComponent<IndividualKeyScript>().StopNote(); //error
        ////            }
        ////            hitObj.Remove(hitObj[i]);
        ////        }
        ////    }
        ////}

        //if (Input.touches.Length <= 0)
        //{
        //    for (int i = 0; i < hitObj.Count; i++)
        //    {
        //        if (hitObj[i].GetComponent<IndividualKeyScript>() != null)
        //        {
        //            hitObj[i].gameObject.GetComponent<IndividualKeyScript>().StopNote();
        //            hitObj.Remove(hitObj[i]);
        //        }
        //    }
        //}
        #endregion 
        int touchIndex = 0;
        foreach(Touch touch in Input.touches)
        {
            RaycastHit hit;
            Ray ray;
            ray = Camera.main.ScreenPointToRay(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if(Physics.Raycast(ray, out hit))
                    {
                        if(hitObj[touch.fingerId].GetComponent<IndividualKeyScript>() == null && hit.collider.gameObject.tag == "Key" && !hitObj.Contains(hit.collider.gameObject))
                        {
                            hitObj[touch.fingerId] = hit.collider.gameObject;
                            hitObj[touch.fingerId].GetComponent<IndividualKeyScript>().PlayNote();
                        }
                    }
                    break;
                case TouchPhase.Moved:
                    break;
                case TouchPhase.Stationary:
                    break;
                case TouchPhase.Ended:
                    if(hitObj[touch.fingerId].GetComponent<IndividualKeyScript>() != null)
                    {
                        hitObj[touch.fingerId].GetComponent<IndividualKeyScript>().StopNote();
                        hitObj[touch.fingerId] = new GameObject();
                    }
                    break;
                case TouchPhase.Canceled:
                    break;
                default:
                    break;
            }

            touchIndex += 1;
        }
    }
}
