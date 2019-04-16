///Author: Adam Warkentin
///This script is attatched to the main camera of the scene. The purpose of this script is to take in touch input, and recognize if the touch was on a key (can be easily modified for other objects)
///Last Modified By: Adam Warkentin
///Last Modified Date: 19-Mar-2019
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
        Input.simulateMouseWithTouches = false;

        hitObj = new List<GameObject>();
        for (int i = 0; i < 160; i++)
        {
            hitObj.Add(new GameObject());
        }
    }

    void FixedUpdate()
    {
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
                        if (hitObj[touch.fingerId].GetComponent<IndividualKeyScript>() != null && hit.collider.gameObject.tag == "Key" && !hitObj.Contains(hit.collider.gameObject))
                        {
                            hitObj[touch.fingerId] = hit.collider.gameObject;
                            hitObj[touch.fingerId].GetComponent<IndividualKeyScript>().PlayNote(false);
                        }
                    }
                    break;
                case TouchPhase.Moved:
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider.gameObject.tag == "Key" && !hitObj.Contains(hit.collider.gameObject))
                        {
                            if (hitObj[touch.fingerId].GetComponent<IndividualKeyScript>() != null)
                            {
                                hitObj[touch.fingerId].GetComponent<IndividualKeyScript>().StopNote();
                            }

                            hitObj[touch.fingerId] = hit.collider.gameObject;
                            hitObj[touch.fingerId].GetComponent<IndividualKeyScript>().PlayNote(false);
                        }
                        else if(hit.collider.gameObject.GetComponent<IndividualKeyScript>() == null)
                        {
                            if (hitObj[touch.fingerId].GetComponent<IndividualKeyScript>() != null)
                            {
                                hitObj[touch.fingerId].GetComponent<IndividualKeyScript>().StopNote();
                            }
                            hitObj[touch.fingerId] = new GameObject();
                        }
                    }
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
        }
    }
}
