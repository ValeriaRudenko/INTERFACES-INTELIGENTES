using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    public GameObject targetObject;
    private bool shouldMoveUp = false;

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("cylinder"))
        {
            GameObject[] group1Spheres = GameObject.FindGameObjectsWithTag("group1");
            foreach (GameObject sphere1 in group1Spheres)
            {
                MeshRenderer sphereRenderer1 = sphere1.GetComponent<MeshRenderer>();
                sphereRenderer1.material.color = Color.yellow;
                sphere1.transform.Translate(Vector3.up * 2.0f);
            }

            GameObject[] group2Spheres = GameObject.FindGameObjectsWithTag("group2");
            foreach (GameObject sphere2 in group2Spheres)
            {
                Vector3 directionToTarget = targetObject.transform.position - sphere2.transform.position;
                sphere2.transform.rotation = Quaternion.LookRotation(directionToTarget);
            }
        }
    }
}