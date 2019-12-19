using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    BossManager mng;

    public float startingHealth = 400f;
    public float currentHealth;

    public AudioSource bossDeathAudio;

    public bool isDead = false;
    bool isSinking;

    void Awake()
    {
        mng = GetComponent<BossManager>();

        currentHealth = startingHealth;
    }


    public void TakeDamage(float amount/*, Vector3 hitPoint*/)
    {
        if(isDead == false)
        {
            Debug.Log("Ała");
            mng.animator.SetTrigger("Damage");
            currentHealth -= amount;
            if (currentHealth <= 0)
            {
                isDead = true;
                Death();
            }
        }

    }

    void Death()
    {
        Debug.Log("Dead");
        mng.animator.SetBool("NotLive", true);
        bossDeathAudio.Play();
    }



}
