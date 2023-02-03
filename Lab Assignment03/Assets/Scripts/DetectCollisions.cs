using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DetectCollisions : MonoBehaviour
{
    // private int AddScore = 1;
    // public Score score;
    [SerializeField] private float maxHealth = 1;
    private float currentHealth = 1;
    //public TextMeshProUGUI ScoreText;
    public int score =0;



    [SerializeField] public HealthBar _healthbar;
    [SerializeField] private Text ScoreTextHandle;


    void Start()
    {
        currentHealth = maxHealth;
        _healthbar.UpdateHealthBar(maxHealth, currentHealth);

        ScoreTextHandle.text = "Score: " + score;

    }
    void update()
    {
        //ScoreText.text = "Score:" ;
        // ScoreTextHandle.text = "Score" + score;
    }

    void OnTriggerEnter(Collider other)
    {
        currentHealth--;

        // Destroy(gameObject);
        // Destroy(other.gameObject);
       if(currentHealth<=0){

        score = score + 1;
        ScoreTextHandle.text = "Score: " + score;

        Destroy(gameObject);
        Destroy(other.gameObject);
        
       }
       else
       {
        _healthbar.UpdateHealthBar(maxHealth, currentHealth);
       }

    }
    
    
    
    // void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Dog")) 
    //     {
    //         Destroy(other.gameObject);
    //     }   
    // }
}

