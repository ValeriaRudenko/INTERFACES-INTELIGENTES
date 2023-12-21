using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notificator : MonoBehaviour
{
    public delegate void MyEvent();
    public event MyEvent OnCubeTrigger;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider trigger) {
        if (trigger.gameObject.tag == "cube") {
            OnCubeTrigger();
        }
    }
}
