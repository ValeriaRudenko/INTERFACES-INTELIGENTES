using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("cube"))
        {
            Debug.Log("Cylinder collided with cube");
        }
        else if (collision.gameObject.CompareTag("sphere"))
        {
            Debug.Log("Cylinder collided with sphere");
        }
    }
}
