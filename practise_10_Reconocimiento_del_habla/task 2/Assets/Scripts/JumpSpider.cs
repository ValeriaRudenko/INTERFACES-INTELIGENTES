using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSpider : MonoBehaviour
{
    public float jumpAmount = 5.0f;
    private bool isGrounded;
    public Rigidbody rb;
   private void OnCollisionEnter(Collision collision)
    {
            isGrounded = true;
    }
    void Update()
    {
        if (isGrounded)
        {

            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
             isGrounded = false;
        }
    }
}
