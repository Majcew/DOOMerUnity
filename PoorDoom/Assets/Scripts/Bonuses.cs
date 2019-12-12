using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonuses : MonoBehaviour
{
    [Header("Type of bonus")]
    public bool isHealth;

    [Header("Bonuses Setting")]
    public float bonusHealth = 40f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            if (isHealth == true)
            {
                if (collision.gameObject.GetComponent<PlayerHealth>().health + bonusHealth > collision.gameObject.GetComponent<PlayerHealth>().maxHealth)
                {
                    collision.gameObject.GetComponent<PlayerHealth>().health = 100f;
                }
                else
                {
                    collision.gameObject.GetComponent<PlayerHealth>().health += bonusHealth;
                }
                Destroy(this.gameObject);
            }
            
        }
    }
    
}
