using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notificator2 : MonoBehaviour
{
    public delegate void MyEvent();
    public event MyEvent OnAnyOtherCollision;
    public event MyEvent OnCollisionWithSphere1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "group1") {
            if (OnCollisionWithSphere1 != null) {
                OnCollisionWithSphere1();
            }
        } else if (collision.gameObject.tag != "plane" && collision.gameObject.tag != "group1") {  
            if (OnAnyOtherCollision != null) {
                OnAnyOtherCollision();
                Debug.Log("col");
            }
        }
    }
}
