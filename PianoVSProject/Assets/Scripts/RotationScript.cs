using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    
    void FixedUpdate()
    {
        transform.Rotate(Vector3.back / 2);
    }
}
