using System.Collections;
using System.Collections.Generic;
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

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("group1"))
        {
            score += 5;
        }
        else if (col.gameObject.CompareTag("group2"))
        {
            score += 10;
        }
        Debug.Log("Score: " + score);
    }
}
