using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;

    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("group1"))
        {
            score += 5;
        }
        else if (col.gameObject.CompareTag("group2"))
        {
            score += 10;
        }
        Destroy(col.gameObject);
        Debug.Log("Score: " + score);
    }
}
