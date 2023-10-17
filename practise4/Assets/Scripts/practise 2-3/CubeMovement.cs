using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float velocityMultiplier = 5.0f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow: " + (verticalInput * velocityMultiplier));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left Arrow: " + (horizontalInput * velocityMultiplier));
        }
    }
}
