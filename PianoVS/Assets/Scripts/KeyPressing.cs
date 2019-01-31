using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressing : MonoBehaviour
{

    RaycastHit hit;
    Vector3 keyPos;

    void start()
    {
        keyPos = transform.position;
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, Vector3.up, out hit))
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
                }

                if (hit.distance < 0.8f)
                {
                    Debug.Log("Too Late");
                    Destroy(hit.transform.gameObject);
                }
            }   
        }
    }

    public void PlayKey()
    {
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
    }
}
