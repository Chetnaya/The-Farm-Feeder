using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public int score = 0;
    public int maxScore;

    void Start()
    {
        score = 0;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
    
    }
    public void updateScore()
    {
        ScoreText.text = "Score 0" + score;
    }

    void update()
    {
        updateScore();
    }



    // public int scoreValue = 0;
    // Text score;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     score = GetComponent<Text>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     score.text = "Score: " +scoreValue;
    // }
}
