using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere1 : MonoBehaviour
{
    public notificator notif;
    // Start is called before the first frame update
    void Start()
    {
      notif = GameObject.Find("Cylinder").GetComponent<notificator>();
      notif.OnCubeTrigger += changeColor;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void changeColor() {
      GetComponent<Renderer>().material.color = new Color(Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));
    }
}
