using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedChairCollision : MonoBehaviour
{
    public float jumpAmount = 3.0f;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("bed"))
        {
            Collider[] chairs = Physics.OverlapSphere(transform.position, 3.0f, LayerMask.GetMask("chair"));
            Debug.Log("Collision with bed");
            foreach (Collider chair in chairs)
            {
                Rigidbody chairRb = chair.GetComponent<Rigidbody>();
                if (chairRb != null)
                {
                    chairRb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
                }
            }
        }
    }
}