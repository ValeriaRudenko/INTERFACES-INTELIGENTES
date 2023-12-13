using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    private GameObject cube;
    private GameObject cylinder;

    private void Start()
    {
        cube = GameObject.FindWithTag("cube");
        cylinder = GameObject.FindWithTag("cylinder");

        if (cube != null && cylinder != null)
        {
            float distance = Vector3.Distance(cube.transform.position, cylinder.transform.position);
            Debug.Log("Distance between Cube and Cylinder: " + distance);
        }
        else
        {
            Debug.LogError("Cube or Cylinder not found.");
        }
    }
}

