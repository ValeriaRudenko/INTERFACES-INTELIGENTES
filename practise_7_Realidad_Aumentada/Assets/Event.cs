using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public void PlayAnimation(){

        Debug.Log("Animation");
        GetComponent<Animation>()["run"].wrapMode = WrapMode.Once;
        GetComponent<Animation>().Play("run");
    }
}
