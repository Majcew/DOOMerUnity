using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    EnemyAttack enemyAttack;
    UnityEngine.AI.NavMeshAgent nav;
    void Awake()
    {
        //szukanie gracza
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        enemyAttack = GetComponent<EnemyAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        
           
        if (enemyHealth.currentHealth > 0 && enemyHealth.currentHealth < enemyHealth.startingHealth || enemyAttack.follow)
        {
            nav.enabled = true;
            nav.SetDestination(player.position);
        }
           
        else
        {
            nav.enabled = false;
        }
    }
}
