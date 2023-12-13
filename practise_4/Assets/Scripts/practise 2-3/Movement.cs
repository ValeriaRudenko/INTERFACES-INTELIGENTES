using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);

        float wInput = Input.GetKey("w") ? 1 : 0;
        float sInput = Input.GetKey("s") ? -1 : 0;
        float aInput = Input.GetKey("a") ? -1 : 0;
        float dInput = Input.GetKey("d") ? 1 : 0;

        Vector3 sphereMovement = new Vector3(aInput + dInput, 0, wInput + sInput) * speed * Time.deltaTime;
        // Move the sphere here
    }
}
