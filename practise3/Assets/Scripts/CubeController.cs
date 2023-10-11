using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public int range = 25;
    private int[] values = new int[5];

    private void Start()
    {
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = Random.Range(0, range);
        }
    }

    private void Update()
    {
        int randomIndex = Random.Range(0, values.Length);
        values[randomIndex] = Random.Range(0, range);

        foreach (int value in values)
        {
            if (value > 15)
            {
                Debug.Log("Cube Value: " + value);
            }
        }
    }
}
