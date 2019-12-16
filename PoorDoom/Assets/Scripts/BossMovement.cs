using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;
    void Awake()
    {
        //szukanie gracza
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHealth.currentHealth<enemyHealth.startingHealth)
            nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        if (enemyHealth.currentHealth > 0 && playerHealth.health > 0)
            nav.SetDestination(player.position);
        else
        {
            nav.enabled = false;
        }
    }
}
