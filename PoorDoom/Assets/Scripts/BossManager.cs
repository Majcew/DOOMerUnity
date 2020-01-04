using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    public Animator animator;

    public GameObject player;
    public PlayerHealth playerHealth;
    public bool startFollow = false;
    

    BossHealth bossHealth;
    BossMovement bossMovement;
    BossAttack bossAttack;

    void Awake()
    {
        animator = GetComponent<Animator>();

        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();

        bossHealth = GetComponent<BossHealth>();
        bossMovement = GetComponent<BossMovement>();
        bossAttack = GetComponent<BossAttack>();
    }


    void Update()
    {
        if(bossMovement.playerInRange == true)
        {
            startFollow = true;
        }

        if(startFollow == true && bossHealth.isDead == false)
        {
            if (bossMovement.playerInRange == true) // zmieniam false na true
            {
                bossMovement.goAndFollow();
            }
            else
            {
                bossMovement.stop();
            }
        }
        else
        {
            bossMovement.stop();
        }

        if(playerHealth.health > 0 && bossMovement.playerInRange == true && bossHealth.isDead == false)
        {
            bossAttack.Attack();
        }

    }


}
