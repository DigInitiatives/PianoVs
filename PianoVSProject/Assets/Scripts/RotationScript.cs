using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///Author: Noah Rittenhouse
///This script will be attached to the central logo so it turns
///Last Modified By: Noah Rittenhouse
///Last Modified Date: Apr-06-2019
///Dependencies: Attached to logo
///
public class RotationScript : MonoBehaviour
{
    //Just rotates at half speed, this is used for the central logo
    void FixedUpdate()
    {
        transform.Rotate(Vector3.back / 2);
    }
}
