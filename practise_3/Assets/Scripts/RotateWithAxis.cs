using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithAxis : MonoBehaviour
{
    public float rotationSpeed = 30.0f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 rotation = new Vector3(0, horizontalInput * rotationSpeed, 0);
        transform.Rotate(rotation * Time.deltaTime);
    }
}
