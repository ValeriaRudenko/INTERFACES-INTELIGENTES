using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    public float speed = 5.0f;

    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
