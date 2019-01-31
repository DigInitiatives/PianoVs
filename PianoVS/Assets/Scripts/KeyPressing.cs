using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressing : MonoBehaviour
{

    RaycastHit hit;
    Vector2 triggerPosition;

    void start()
    {
        triggerPosition = transform.position;
        triggerPosition.y = transform.position.y + 10000;
        
    }

    void Update()
    {

        if (Physics.Raycast(transform.position, Vector3.up))
        {
            //if ()
            //{
            //    Debug.Log("in Range");
            //}
           
        }
    }

    public void PlayKey()
    {
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);  
    }
}
