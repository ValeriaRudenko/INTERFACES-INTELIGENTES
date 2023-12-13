using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghoul_move : MonoBehaviour
{
    public float speed = 5.0f;
    public float GhoulJumpHeight = 5.0f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        float wInput = Input.GetKey("w") ? 1 : 0;
        float sInput = Input.GetKey("s") ? -1 : 0;
        float aInput = Input.GetKey("a") ? -1 : 0;
        float dInput = Input.GetKey("d") ? 1 : 0;

         if (Input.GetKeyDown(KeyCode.Space))
        { 
            transform.position += new Vector3(0, GhoulJumpHeight, 0);
        }
        
        Vector3 GhoulMovement = new Vector3(aInput + dInput, 0, wInput + sInput) * speed * Time.deltaTime;

        transform.Translate(GhoulMovement);
    }

}