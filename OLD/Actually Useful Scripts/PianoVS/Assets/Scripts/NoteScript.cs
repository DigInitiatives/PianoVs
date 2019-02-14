using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Austin Bentley
 * Last Edited on : January 31st 2019
 * This script is designed to send notes down the track
**/
public class NoteScript : MonoBehaviour
{
    void Update()
    {
		transform.Translate(new Vector3(0, -.03f, 0));
    }
}
