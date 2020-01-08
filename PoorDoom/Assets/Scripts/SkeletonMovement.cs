using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;
    Animator anim;
    
    public float maximumLookDistance = 200;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        anim = GetComponent<Animator>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
       
    }

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(player.position, transform.position);
        Debug.Log(distance.ToString());
       
        if (enemyHealth.currentHealth > 0 && playerHealth.health > 0 && distance < maximumLookDistance)
        {
            anim.SetTrigger("FollowPlayer");
            nav.SetDestination(player.position);
        }
           
        else
        {
            nav.ResetPath();
            anim.SetTrigger("PlayerDead");
        }
    }
}
