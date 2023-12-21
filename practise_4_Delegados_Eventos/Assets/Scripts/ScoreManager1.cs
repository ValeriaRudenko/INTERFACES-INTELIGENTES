using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager2 : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    public GameObject sphere;
    public GameObject sphere2;

    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("group1"))
        {
            score += 5;
            Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 0, Random.Range(-10.0F, 10.0F));
            Instantiate(sphere, position, Quaternion.identity);
        }
        else if (col.gameObject.CompareTag("group2"))
        {
            score += 10;
            Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 0, Random.Range(-10.0F, 10.0F));
            Instantiate(sphere2, position, Quaternion.identity);
        }
        Destroy(col.gameObject);
        
        Debug.Log("Score: " + score);
    }
}
