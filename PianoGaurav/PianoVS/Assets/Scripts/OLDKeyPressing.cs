using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OLDKeyPressing : MonoBehaviour
{
    public bool hitNote;
    protected int counter;

    void Start()
    {
        hitNote = false;
    }

    public void PlayKey()
    {
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
    }

    void OnTriggerEnter(Collider other)
    {
        counter++;
        if (other.gameObject.tag == "BlackNote" && Input.GetKeyDown(KeyCode.A))
        {
            Destroy(other);
            Debug.Log("C");
        }

    }
    
}
