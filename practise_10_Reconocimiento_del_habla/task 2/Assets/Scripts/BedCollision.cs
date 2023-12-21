using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedCollision : MonoBehaviour
{
    public float jumpAmount = 5.0f;
    public float moveSpeed = 5.0f;
    private bool moveRight = true;

    private bool canMove = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (canMove && collision.gameObject.CompareTag("Bed"))
        {
            StartCoroutine(MoveBedAndChairs());
        }
    }

    private IEnumerator MoveBedAndChairs()
    {
        canMove = false; 

        GameObject[] chairs = GameObject.FindGameObjectsWithTag("Chair");
        foreach (GameObject chair in chairs)
        {
            Rigidbody chairRb = chair.GetComponent<Rigidbody>();
            if (chairRb != null)
            {
                chairRb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
            }
        }

        GameObject[] beds = GameObject.FindGameObjectsWithTag("Bed");

        float startTime = Time.time;
        while (Time.time - startTime < 1.0f) // Move for 2 seconds
        {
            foreach (GameObject bed in beds)
            {
                Vector3 moveVector = moveRight ? Vector3.right : Vector3.left;
                bed.transform.Translate(moveVector * moveSpeed * Time.deltaTime);
            }

            yield return null;
        }
        moveRight = !moveRight;
        canMove = true;
    }
}
