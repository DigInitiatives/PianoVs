using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///Author: Noah Rittenhouse
///This script will be attached to each of the deathzones below the keyboards, any note or note bar will be destroyed or moved
///Last Modified By: Noah Rittenhouse
///Last Modified Date: Apr-06-2019
///Dependencies: Attached to deathzones
///
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
