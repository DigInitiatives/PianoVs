using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressing : MonoBehaviour
{

    bool keyInTrigger;
    GameObject note;

    void start()
    {
        keyInTrigger = false;
    }

    void Update()
    {
        if (keyInTrigger == true && Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Note Hit Sweet Spot");
            PlayKey();
            Destroy(note);
        }

    }

    public void PlayKey()
    {
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);  
    }

    void OnTriggerEnter(Collider col)
    {  
        keyInTrigger = true;
        note = col.gameObject;
    }

    void OnTriggerExit(Collider col)
    {
        Debug.Log("Exit");
        keyInTrigger = false;
        Debug.Log("Too Late");
        Destroy(note);
    }
}
