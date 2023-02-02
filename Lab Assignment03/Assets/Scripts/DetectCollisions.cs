using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DetectCollisions : MonoBehaviour
{
    // private int AddScore = 1;
    // public Score score;
    [SerializeField] private float maxHealth = 3;
    private float currentHealth = 3;


    [SerializeField] public HealthBar _healthbar;

    void Start()
    {
        currentHealth = maxHealth;
        _healthbar.UpdateHealthBar(maxHealth, currentHealth);
    }

    void OnTriggerEnter(Collider other)
    {
        // Destroy(gameObject);
        // Destroy(other.gameObject);
       if(currentHealth<=0){
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

