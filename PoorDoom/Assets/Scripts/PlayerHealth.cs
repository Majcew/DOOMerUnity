using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Text healthText;
    public float health;
    public float maxHealth = 100f;

    bool isDead;
    bool damaged;

    void Start()
    {
        health = 100f;

        SetHealthText();
    }

    public void SetHealthText()
    {
        healthText.text = "Lives: " + health.ToString();
    }
    public void TakeDamage (float amount)
    {
        damaged = true;
        health -= amount;
        if(health <= 0 && !isDead)
        {
            isDead = true;
            health = 0;
        }
        SetHealthText();
    }


}
