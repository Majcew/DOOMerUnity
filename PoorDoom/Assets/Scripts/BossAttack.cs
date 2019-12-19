using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public float attackDamage = 10f;
    float timer=0f;
    bool canAttack = true;
    public AudioSource bossHitAudio;

    BossManager mng;

    private void Awake()
    {
        mng = GetComponent<BossManager>();
    }
    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeBetweenAttacks)
        {
            canAttack = true;
        }
        else
        {
            canAttack = false;
        }
    }

    public void Attack()
    {
        
        //event do zmiany animacji
        if (canAttack==true)
        {
            Debug.Log("Atak!");
            Debug.Log(timer);
            mng.animator.SetTrigger("Attack");
            mng.playerHealth.TakeDamage(attackDamage);
            timer = 0f;
            bossHitAudio.Play();
        }
    }
}
