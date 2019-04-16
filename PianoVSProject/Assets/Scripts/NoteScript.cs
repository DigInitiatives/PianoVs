///Author: Austin Bentley
///This script simply moves the attached object down
///Last Modified By: Austin Bentley
///Last Modified Date: 31-Jan-2019
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour
{
    void FixedUpdate()
    {
		transform.Translate(new Vector3(0, -0.055f, 0));
    }
}
