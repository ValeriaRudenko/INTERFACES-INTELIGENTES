using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere1task2 : MonoBehaviour
{
    public notificator2 notif;
    // Start is called before the first frame update
    void Start()
    {
      notif = GameObject.FindWithTag("cube").GetComponent<notificator2>();
      notif.OnAnyOtherCollision += MoveTowardsCylinder;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void MoveTowardsCylinder() {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Vector3 direction_to_cylinder = Vector3.Normalize(GameObject.FindWithTag("cylinder").transform.position - transform.position);
        Debug.Log(direction_to_cylinder);
        rigidbody.AddForce(direction_to_cylinder * 150);
    }
}
