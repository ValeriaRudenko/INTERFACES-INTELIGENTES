using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notificator3 : MonoBehaviour
{
    public delegate void MyEvent();
    public event MyEvent OnGettingCloserToCylinder;
    private float previous_distance = 0f;

    // Start is called before the first frame update
    void Start()
    {
        previous_distance = Vector3.Distance(GameObject.FindGameObjectWithTag("cylinder").transform.position, transform.position);
    }


    void FixedUpdate()
    {
        float current_distance = Vector3.Distance(GameObject.FindGameObjectWithTag("cylinder").transform.position, transform.position);
        if (current_distance  < previous_distance) {
            if (OnGettingCloserToCylinder != null) {
                OnGettingCloserToCylinder();
            }
        }
        previous_distance = current_distance;
    }
}
