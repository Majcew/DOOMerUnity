using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Text healthText;
    private PlayerMovement playerspeeds;
    private float originalWalkingSpeed;
    private float originalRunningSpeed;
    public float health;
    public float maxHealth = 100f;

    bool isDead;
    bool damaged;

    private void Awake()
    {
        playerspeeds = GetComponent<PlayerMovement>();
        originalRunningSpeed = GetComponent<PlayerMovement>().playerRunningSpeed;
        originalWalkingSpeed = GetComponent<PlayerMovement>().playerWalkingSpeed;
    }

    private void Update()
    {
        
    }

    public void CheckHP()
    {
        if(health<=30)
        {
            playerspeeds.playerWalkingSpeed = originalWalkingSpeed * 0.3f;
            playerspeeds.playerRunningSpeed = originalRunningSpeed * 0.3f;
        }
        if(health<=60 && health > 30)
        {
            playerspeeds.playerWalkingSpeed = originalWalkingSpeed * 0.75f;
            playerspeeds.playerRunningSpeed = originalRunningSpeed * 0.75f;
        }
        if(health>60)
        {
            playerspeeds.playerWalkingSpeed = originalWalkingSpeed;
            playerspeeds.playerRunningSpeed = originalRunningSpeed;
        }

    }

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
        GameOver(isDead);
        SetHealthText();
        CheckHP();
    }

    [Obsolete]
    public void GameOver(bool dead)
    {
        if(dead == true)
        {
            Application.LoadLevel(Application.loadedLevel);
            Debug.Log("Zginalem");
        }
    }


}
