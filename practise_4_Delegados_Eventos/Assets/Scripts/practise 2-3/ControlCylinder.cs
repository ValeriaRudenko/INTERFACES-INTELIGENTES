using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCylinder : MonoBehaviour
{
    public Transform sphere;
    public float force = 10.0f;
    public float friction = 0.5f;

    void Update()
    {
        Vector3 direction = (sphere.position - transform.position).normalized;
        GetComponent<Rigidbody>().AddForce(direction * force);

        if (friction > 0)
        {
            GetComponent<Rigidbody>().velocity *= (1 - friction * Time.deltaTime);
        }
    }
}

