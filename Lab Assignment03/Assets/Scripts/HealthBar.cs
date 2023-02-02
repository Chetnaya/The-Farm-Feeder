using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // public float maxHealth;
    // public float currentHealth;


    [SerializeField] public Image _healthbarSprite;

    // public float maxHealth;
    // public float currentHealth;
    
    // public void UpdateHealthBar(float maxHealth, float currentHealth)

    public void UpdateHealthBar(float maxHealth, float currentHealth)
    {
        _healthbarSprite.fillAmount = currentHealth / maxHealth;
    }
}
