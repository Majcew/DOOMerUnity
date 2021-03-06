﻿using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public DiamondCollector diamondCollector;
    public GameObject player;
    public PlayerMovement pm;
    public GameObject door;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        diamondCollector = player.GetComponent<DiamondCollector>();
        pm = player.GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (diamondCollector.allDiamondsTaken == true && pm.inBossRoom==false)
        {
            Debug.Log("ołpen");
            door.SetActive(false);
            //Destroy(gameObject);
        }

    }
}
