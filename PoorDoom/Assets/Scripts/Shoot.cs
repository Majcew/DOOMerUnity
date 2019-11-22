using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public int bulletsPerMag = 30;
    public int bulletsLeft = 120;
    public int bulletsInMag = 30;
    public Text ammoinmagText;
    public Text overallammoText;
    //public Transform shootPoint;
    public Camera fpscam;
    //public ParticleSystem muzzleshot;
    public float fireRate = 0.1f;
    public float damage = 10f;
    float fireTimer;
    public AudioSource audio;
    public AudioClip shootingsound;
    // Start is called before the first frame update
    void Start()
    {
        ShowAmmoInMag();
        ShowAmmoLeft();
    }

    private void ShowAmmoLeft()
    {
        overallammoText.text = bulletsLeft.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;
        if (Input.GetButton("Fire1") && fireTimer > fireRate)
        {
            ShootBullet();
            fireTimer = 0;
        }
        if(Input.GetKey("r") && bulletsInMag < bulletsPerMag)
        {
            ReloadMag();
        }
    }


    private void ShootBullet()
    {
        if (bulletsInMag != 0)
        {
            bulletsInMag--;
            audio.PlayOneShot(shootingsound);
            RaycastHit hit;
            if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit))
            {
                Debug.Log(hit.transform.name);
                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.TakeDamage(damage);
                }

                Debug.Log(hit.transform.name);
                EnemyHealth enemyHealth = hit.transform.GetComponent<EnemyHealth>();
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage(damage);
                }

                WoodenChestController woodenChestController = hit.transform.GetComponent<WoodenChestController>();
                if (woodenChestController != null)
                {
                    woodenChestController.TakeDamage(damage);
                }

            }
            ShowAmmoInMag();
        }
    }
    private void ReloadMag()
    {
        int amountToReload = bulletsPerMag - bulletsInMag;
        if (bulletsLeft <= amountToReload && bulletsLeft != 0)
        {
            bulletsInMag += bulletsLeft;
            bulletsLeft = 0;
            ShowAmmoInMag();
            ShowAmmoLeft();
        }
        else if(bulletsLeft!=0)
        {
            bulletsInMag += amountToReload;
            bulletsLeft -= amountToReload;
            ShowAmmoInMag();
            ShowAmmoLeft();
        }
    }

    private void ShowAmmoInMag()
    {
        ammoinmagText.text = bulletsInMag.ToString() + "/";
    }
}
