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
    bool keyHeld;
    float longNoteScoreTimer;

    void start()
    {
        keyHeld = false;
        longNoteScoreTimer = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, Vector3.up, out hit, 1.5f))
            {
                PlayKey();

                if (hit.collider.tag == "LongNote")
                {
                    Debug.Log("Key Held");
                    keyHeld = true;
                }

                if (hit.collider.tag == "WhiteNote")
                {
                    if (hit.distance < 1.7f)
                    {
                        Debug.Log("Too Early");
                        ScoreTracker.HalfHit();
                        Destroy(hit.transform.gameObject);
                    }
                    else if (hit.distance < 1.2f)
                    {
                        Debug.Log("Sweet Spot");
                        ScoreTracker.PerfectHit();
                        Destroy(hit.transform.gameObject);
                    }
                    else if (hit.distance < 0.8f)
                    {
                        Debug.Log("Too Late");
                        Destroy(hit.transform.gameObject);
                    }
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Key Released");
            keyHeld = false;
        }

        longNoteScoreTimer += Time.deltaTime;
        if (keyHeld == true && longNoteScoreTimer > 0.3f)
        {
            longNoteScoreTimer = 0;
            ScoreTracker.PerfectHit();

            if (Physics.Raycast(transform.position, Vector3.up, out hit, 1.5f))
            {
                if (hit.collider.tag != "LongNote")
                {
                    
                    keyHeld = false;
                    
                }
            }
        }

        Debug.Log(ScoreTracker.score);

    }

    // Plays the sound for the key
    public void PlayKey()
    {
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
    }
}
