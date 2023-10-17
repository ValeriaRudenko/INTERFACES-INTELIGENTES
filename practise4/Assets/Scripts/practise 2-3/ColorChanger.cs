using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color color;
   

    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && gameObject.tag == "cylinder")
        {
            renderer.material.color = color;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && gameObject.tag == "cube")
        {
            renderer.material.color = color;
        }
    }   
}

