using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public int score;

    public Text ScoreDisplay;

    public Text ScoreDisplay1;

    public GameObject LevelComplete;

    public GameObject Blob;

    public GameObject Score;

    public GameObject Healthbar;

    public int scorelimit = 20;

    

    private void Update()
    {
        ScoreDisplay.text = score.ToString();
        ScoreDisplay1.text = score.ToString();
        

        if (score >= scorelimit)
        {

            LevelComplete.SetActive(true);
            Destroy(gameObject);
            Destroy(Blob);
            Destroy(Healthbar);
            Destroy(Score);

        }
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
