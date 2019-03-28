using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachedLineRenderer : MonoBehaviour
{
    LineRenderer line;
    CapsuleCollider capsule;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        capsule = GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        if (capsule.center != (line.GetPosition(0) + (line.GetPosition(1) - line.GetPosition(0)) / 2))
        {
            capsule.center = line.GetPosition(0) + (line.GetPosition(1) - line.GetPosition(0)) / 2;
        }

        if (capsule.height != ((line.GetPosition(1) - line.GetPosition(0)).magnitude))
        {
            capsule.height = (line.GetPosition(1) - line.GetPosition(0)).magnitude;
        }
    }
}
