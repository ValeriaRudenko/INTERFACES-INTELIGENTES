using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeToSphere : MonoBehaviour
{
    public Transform sphere;
    public float speed = 5.0f;

    void Update()
    {
        Vector3 direction = (sphere.position - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
