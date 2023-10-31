using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpider : MonoBehaviour
{
    public Transform targetObject; // Reference to the target object in the Inspector
    public float speed = 1.0f;

    private void Update()
    {
        if (targetObject != null)
        {
            Vector3 targetPosition = targetObject.position;
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
        }
    }
}