///Author: Austin Bentley
///This script simply moves the attached object down
///Last Modified By: Josh Sadoway
///Last Modified Date: 26-Mar-2019
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector3(0, -(5 * Time.fixedDeltaTime), 0));
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Deathzone")
        {
            if (gameObject.tag == "NoteBar")
            {
                Destroy(gameObject);
            }
            else
            {
                transform.position = new Vector3(-1000, -1000, -1000);
                gameObject.SetActive(false);
            }
        }
    }
}
