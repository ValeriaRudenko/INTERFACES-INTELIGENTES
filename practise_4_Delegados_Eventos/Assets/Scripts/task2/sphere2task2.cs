using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere2task2 : MonoBehaviour
{
    public notificator2 notif;
    // Start is called before the first frame update
    void Start()
    {
      notif = GameObject.FindWithTag("cube").GetComponent<notificator2>();
      notif.OnCollisionWithSphere1 += GetBigger;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void GetBigger() {
      GetComponent<Transform>().localScale += new Vector3(0.3f, 0.3f, 0.3f);
    }
}
