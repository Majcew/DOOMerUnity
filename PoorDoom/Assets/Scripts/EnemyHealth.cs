using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float startingHealth = 40f;
    public float currentHealth;
    public float sinkSpeed = 2.5f; //szybkość znikania w podłodze
    //public int scoreValue = 10;
    //nie wiem, czy będziemy dawać punkty, ale to na razie zostawię
    public AudioClip deathClip;

    Animator anim;
    AudioSource enemyAudio;
    //ParticleSystem hitParticles;
    //do efektów krwi przy trafieniu, nie ruszałem
    CapsuleCollider capsuleCollider;
    bool isDead;
    bool isSinking;
    void Awake()
    {
        anim = GetComponent<Animator>();
        enemyAudio = GetComponent<AudioSource>();
        //hitParticles = GetComponentInChildren<ParticleSystem>();
        capsuleCollider = GetComponent<CapsuleCollider>();
        currentHealth = startingHealth;
    }

    
    void Update()
    {
        if(isSinking){
            transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime );
        }
    }

    public void TakeDamage(float amount/*, Vector3 hitPoint*/){
        if(isDead)
            return;
        enemyAudio.Play();
        anim.SetTrigger("GetHurt");
        currentHealth -= amount;
        anim.SetTrigger("PlayerOutOfRange");
        //hitParticles.transform.position = hitPoint;
        //hitParticles.Play();
        if(currentHealth <=0){
            Death();
        }
    }


    void Death(){
        isDead = true;

        capsuleCollider.isTrigger = true;

        //event do zmiany animacji
        anim.SetTrigger("Dead");
        enemyAudio.clip = deathClip;
        enemyAudio.Play();
        StartSinking();

    }

    public void StartSinking(){
        GetComponent <UnityEngine.AI.NavMeshAgent>().enabled = false;
        GetComponent <Rigidbody>().isKinematic = true;
        isSinking = true;
        //ScoreManager.score += scoreValue;
        Destroy (gameObject, 6f);
    }


}
