using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int bulletsPerMag = 30;
    public int bulletsLeft = 0;
    //public Transform shootPoint;
    public Camera fpscam;
    //public ParticleSystem muzzleshot;
    public float fireRate = 0.1f;
    public float damage = 10f;
    float fireTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            ShootBullet();
        }

        if (fireTimer < fireRate)
            fireTimer += Time.deltaTime;
    }

    private void ShootBullet()
    {
        //muzzleshot.Play();
        RaycastHit hit;
        Debug.Log("Shot fired!");
        if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            Debug.Log(hit.transform.name);
            EnemyHealth enemyHealth = hit.transform.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }
        }
    }
}
