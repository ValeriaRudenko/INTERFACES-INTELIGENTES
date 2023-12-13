using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText; 
    private int score = 0;

    void Start()
    {
        UpdateScoreText(); 
    }

    
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

   
    void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        UpdateScoreText(); 
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Spider"))
            AddPoints(10);
    }
}
