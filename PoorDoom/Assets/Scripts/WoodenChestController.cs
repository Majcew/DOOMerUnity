using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenChestController : MonoBehaviour
{
    public float CheastHealth = 10;
    public AudioSource audioSourceChestCrash;
    bool flag = false;
    Collider chestCollider;
    public bool playSound = false;
    private bool runOnceFlag = false;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        chestCollider = GetComponent<Collider>();
    }

    void PlaySound()
    {
        audioSourceChestCrash.Play();
    }

    private void Update()
    {
        if(playSound == true && runOnceFlag == false)
        {
            PlaySound();
            runOnceFlag = true;
        }
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
                chestCollider.enabled = !chestCollider.enabled;
                //PlaySound();
            }

            flag = true;
        }
    }
}
