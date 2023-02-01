using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // private int AddScore = 1;
    public Score score;


    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        score.AddScore(1);

        // ScoreScript.scoreValue += 1;
        // other.GetComponent<Score>().scoreValue += AddScore;

    }
    
    
    
    // void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Dog")) 
    //     {
    //         Destroy(other.gameObject);
    //     }   
    // }
}

