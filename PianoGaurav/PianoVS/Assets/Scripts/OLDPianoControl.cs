using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoControl : MonoBehaviour
{
    //public List<GameObject> whiteKeys = new List<GameObject>();
    //public List<GameObject> blackKeys = new List<GameObject>();

    //public List<AudioClip> whiteKeySounds = new List<AudioClip>();
    //public List<AudioClip> blackKeySounds = new List<AudioClip>();

    //AudioSource audioSource = new AudioSource();

    //public void PlayWhiteKey(int key)
    //{

    //}

    private RaycastHit hit;
    private Vector3 originPoint;

    public void Update()
    {
        if (Physics.Raycast(originPoint, Vector3.up, out hit))
        {
            if (hit.collider.tag == "Whitekeys" && hit.distance < 5 && hit.distance > 1)
            {
                Debug.Log("We IN THIS BI...");
                Debug.DrawLine(originPoint, hit.collider.gameObject.transform.position);
            }
            else if (hit.distance < 10)
            {
                Debug.Log("Nope");
            }

        }
    }


}
