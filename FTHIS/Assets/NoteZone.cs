using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteZone : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Note" && GetComponentInParent<PlayerDataManager>().isAI)
        {
            collider.GetComponent<>
            PlayNote(AI);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Note" && GetComponentInParent<PlayerDataManager>().isAI)
        {
            StopNote();
        }
    }
}
