using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    void Update()
    {
        scoreText.text = "Score: " + ScoreManager.score.ToString();
    }
    public static int score = 0;

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            // Check if the collision occurred on the top side of the object (you can adjust the threshold as needed).
            if (contact.normal == Vector3.up)
            {
                if (collision.gameObject.CompareTag("Spider"))
                {
                    score += 10;
                    Debug.Log("Score: " + score);
                }
            }
        }
    }
}
