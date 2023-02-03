using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score_Dog : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    // public Text ScoreText;
    public int score;

    void Start()
    {
        score = 0;
        ScoreText.text = "Score:";
    }
    
    
    public void updateScore()
    {
        ScoreText.text = "Score:" + score;
    }

    void OnTriggerEnter(Collider other)
    {
        score = score + 1;

        // Destroy(gameObject);
        // Destroy(other.gameObject);


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

