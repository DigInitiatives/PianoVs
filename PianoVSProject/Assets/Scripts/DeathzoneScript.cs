using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathzoneScript : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Note"|| collision.gameObject.tag == "HeldNote")
        {
            collision.transform.position = new Vector3(-1000, -1000, -1000);
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "NoteBar")
        {
            Destroy(collision.gameObject);
        }
    }
}
