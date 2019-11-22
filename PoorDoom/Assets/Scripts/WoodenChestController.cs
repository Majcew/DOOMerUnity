using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenChestController : MonoBehaviour
{
    public float CheastHealth = 10;
    public AudioSource audioSourceChestCrash;
    bool flag = false;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void PlaySound()
    {
        audioSourceChestCrash.Play();
    }

    public void TakeDamage(float amount)
    {
        CheastHealth -= amount;

        if (CheastHealth <= 0)
        {
            if(flag == false)
            {
                animator.SetBool("isCrashed", true);
                //yield return new WaitForSeconds(1);
                PlaySound();
            }

            flag = true;
        }
    }
}
