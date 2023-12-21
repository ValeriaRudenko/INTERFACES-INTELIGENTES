using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere1task3 : MonoBehaviour
{
    public notificator3 notif;
    private bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
      notif = GameObject.FindGameObjectWithTag("cube").GetComponent<notificator3>();
      notif.OnGettingCloserToCylinder += ChangeColorAndJump;    
    }

    void ChangeColorAndJump() {
      Vector3 jump_direction = new Vector3(0f,5f,0f);
      if (!isJumping) {
            GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

            GetComponent<Rigidbody>().AddForce(jump_direction, ForceMode.Impulse);
        isJumping = true;
      }
    }
 
  void OnCollisionEnter(Collision collision) {
      if (collision.gameObject.tag == "plane") {
        isJumping = false;
      }
    }

}
