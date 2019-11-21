using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float startingHealth = 100f;
    public float currentHealth;

    bool isDead;
    bool damaged;

    void Awake()
    {
        currentHealth = startingHealth;
    }


    //void Update()
    //{
        
    //}
    public void TakeDamage (float amount)
    {
        damaged = true;
        currentHealth -= amount;
        if(currentHealth <= 0 && !isDead)
        {
            isDead = true;
        }
    }


}
