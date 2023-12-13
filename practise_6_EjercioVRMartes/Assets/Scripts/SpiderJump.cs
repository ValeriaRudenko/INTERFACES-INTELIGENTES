using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderJump : MonoBehaviour
{
    public float jumpForse = 3.0f;
    private bool isGrounded;
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (isGrounded)
        {
            rigidbody.AddForce(Vector3.up * jumpForse, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}