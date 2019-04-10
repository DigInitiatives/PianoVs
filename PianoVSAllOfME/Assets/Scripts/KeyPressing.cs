using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressing : MonoBehaviour
{
    public void PlayKey()
    {
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
    }
}
