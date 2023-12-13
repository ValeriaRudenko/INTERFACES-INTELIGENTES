using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group2Controller : MonoBehaviour
{
    private GameObject cube;
    public GameObject[] group2Spheres;

    private void Start()
    {
        cube = GameObject.FindWithTag("cube");
        float minDistance = float.MaxValue;
        GameObject closestSphere = null;

        foreach (GameObject sphere in group2Spheres)
        {
            float distance = Vector3.Distance(sphere.transform.position, cube.transform.position);

            if (distance < minDistance)
            {
                minDistance = distance;
                closestSphere = sphere;
            }
        }

        // Increase the height (y) of the closest sphere
        if (closestSphere != null)
        {
            Vector3 newPosition = closestSphere.transform.position;
            newPosition.y += 10.0f;
            closestSphere.transform.position = newPosition;
        }
    }

    private void Update()
    {
       

        // Change color of the farthest sphere on space key press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float maxDistance = float.MinValue;
            GameObject farthestSphere = null;

            foreach (GameObject sphere in group2Spheres)
            {
                float distance = Vector3.Distance(sphere.transform.position, cube.transform.position);

                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    farthestSphere = sphere;
                }
            }

            if (farthestSphere != null)
            {
                Renderer sphereRenderer = farthestSphere.GetComponent<Renderer>();
                sphereRenderer.material.color = Color.red;
            }
        }
    }
}

