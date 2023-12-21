using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpiderB : MonoBehaviour
{
     public Transform targetObject; // Reference to the target object in the Inspector
    
    public Transform targetObject2; // Reference to the target object in the Inspector
    public float speed = 2.0f;
 bool moveToTarget2 = true;
    private void Update()
    {
       
        if (targetObject != null)
        {
            Vector3 targetPosition = targetObject.position;
            Vector3 targetPosition2 = targetObject2.position;
            float step = speed * Time.deltaTime;
            
           float tolerance = 1.0f; // Adjust the tolerance value as needed

            if (Mathf.Abs(transform.position.x - targetPosition.x) <= tolerance && Mathf.Abs(transform.position.z - targetPosition.z) <= tolerance)
            {
                moveToTarget2 = true;
                
            }

            if (Mathf.Abs(transform.position.x - targetPosition2.x) <= tolerance && Mathf.Abs(transform.position.z - targetPosition2.z) <= tolerance)
            {
                moveToTarget2 = false;
            }


            if(moveToTarget2 == true){
                transform.position = Vector3.MoveTowards(transform.position, targetPosition2, step);
            }else
            {
               transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
            }
        }
    }
}
