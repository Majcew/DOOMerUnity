using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    GameObject player;
    PlayerMovement coins;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        coins = player.GetComponent<PlayerMovement>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            coins.CollectCoin();
            Destroy(gameObject);
        
        }

        
    }
}
