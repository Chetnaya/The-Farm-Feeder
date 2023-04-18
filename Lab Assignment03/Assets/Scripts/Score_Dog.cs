using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using TMPro;

public class Score_Dog : MonoBehaviour
{
    // private DetectCollisions _detectcollisions;

    // [SerializeField] private Text ScoreTextHandle;
    [SerializeField] private Text ScoreTextHandle;

    // [SerializeField] private float currentHealth = 1;
    // public health = DetectCollisions.currentHealth;
    
    public int score = 0;
    public int incrementscore = 0;
    private int finalscore;
    
    void Start()
    {
       ScoreTextHandle.text = "Score: " + score;
    }

    
    // public void updateScore()
    // {
    //     ScoreText.text = "Score:" + score;
    // }

    void OnTriggerEnter(Collider other)
    {
        if(DetectCollisions.currentHealth==0)
        {
        finalscore = score + incrementscore;
        ScoreTextHandle.text = "Score: " + finalscore;

        }


    }
    
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

