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
		transform.Translate(new Vector3(0, -(0.1f), 0));
    }
}
