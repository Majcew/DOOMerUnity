using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public DiamondCollector diamondCollector;
    public GameObject player;
    public PlayerMovement pm;
    public GameObject door;
    public BossManager boss;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        diamondCollector = player.GetComponent<DiamondCollector>();
        pm = player.GetComponent<PlayerMovement>();
    }

    private void Update()
    {

        if (pm.inBossRoom == true)
        {
            door.SetActive(true);
            boss.startFollow = true;
        }

    }
}
