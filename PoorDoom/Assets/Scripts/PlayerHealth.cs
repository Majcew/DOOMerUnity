using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Text healthText;
    public float health;

    bool isDead;
    bool damaged;

    void Start()
    {
        health = 100f;

        SetHealthText();
    }

    private void SetHealthText()
    {
        healthText.text = "Lives: " + health.ToString();
    }


    //void Update()
    //{

    //}
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
