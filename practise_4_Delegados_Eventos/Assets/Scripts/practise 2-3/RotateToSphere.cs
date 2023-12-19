using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToSphere : MonoBehaviour
{
    public Transform sphere;

    void Update()
    {
        transform.LookAt(sphere);
    }
}

