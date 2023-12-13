using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 vector1;
    public Vector3 vector2;

    private void Start()
    {
        float magnitude1 = vector1.magnitude;
        float magnitude2 = vector2.magnitude;
        float angle = Vector3.Angle(vector1, vector2);
        float distance = Vector3.Distance(vector1, vector2);

        Debug.Log("Magnitude of Vector1: " + magnitude1);
        Debug.Log("Magnitude of Vector2: " + magnitude2);
        Debug.Log("Angle between Vector1 and Vector2: " + angle);
        Debug.Log("Distance between Vector1 and Vector2: " + distance);

        if (vector1.y > vector2.y)
        {
            Debug.Log("Vector1 is at a greater height.");
        }
        else
        {
            Debug.Log("Vector2 is at a greater height.");
        }
    }
}


