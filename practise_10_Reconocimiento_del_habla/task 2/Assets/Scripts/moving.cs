using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    //Movement Variables
    public float moveSpeed = 2.0f;
    public Rigidbody rb;
    public float jumpAmount = 5.0f;
    private bool isGrounded;

    void Update()
    {
        // Jump when the Spacebar is pressed and the object is grounded
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
             isGrounded = false;
        }
       // if (Input.GetKeyDown(KeyCode.Space))
        //{
         //   transform.position += new Vector3(0, playerJumpHeight, 0);
        //}
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;

        transform.Translate(movement);
    }
    private void OnCollisionEnter(Collision collision)
    {
            isGrounded = true;
    }
}
