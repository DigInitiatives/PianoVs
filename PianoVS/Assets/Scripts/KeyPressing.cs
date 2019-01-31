///Header Template
///Author: Angelo Divinagracia
///Purpose of Script:Detect notes using raycasting
///Last Modified By: Angelo Divinagracia
///Last Modified Date: 31-Jan-2019 
///Dependencies:
///		RigidBody (Example)
///			IsKinematic = False
///			Weight = 10
///			Movement Freezed on Z Axis*
///			Rotation Freezed on X and Y Axis
///			
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressing : MonoBehaviour
{
    RaycastHit hit;

    void start()
    {

    }

    void Update()
    {
        // Shoot a raycast up and detect if the note is in the sweet spot or not
        if (Physics.Raycast(transform.position, Vector3.up, out hit, 1.5f))
        {
            if (hit.collider.tag == "WhiteNote")
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (hit.distance < 1.2f)
                    {
                        Debug.Log("Sweet Spot");
                        Destroy(hit.transform.gameObject);
                    }
                    else
                    {
                        Debug.Log("Too Early");
                        Destroy(hit.transform.gameObject);
                    }

                    PlayKey();
                }

                if (hit.distance < 0.8f)
                {
                    Debug.Log("Too Late");
                    Destroy(hit.transform.gameObject);
                }
            }   
        }
    }

    // Plays the sound for the key
    public void PlayKey()
    {
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
    }
}
