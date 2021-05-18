using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public int score;

    public Text ScoreDisplay;

    public Text ScoreDisplay1;

    private void Update()
    {
        ScoreDisplay.text = score.ToString();
        ScoreDisplay1.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {

            score++;
            Debug.Log(score);
            

        }

        
    }
}
