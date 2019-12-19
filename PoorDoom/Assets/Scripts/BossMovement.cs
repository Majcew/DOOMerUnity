using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    BossManager mng;

    Transform playerTransform;

    UnityEngine.AI.NavMeshAgent navMesh;

    public bool playerInRange = false;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == mng.player)
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == mng.player)
        {
            playerInRange = false;
        }
    }

    void Awake()
    {
        mng = GetComponent<BossManager>();
        
        playerTransform = mng.player.transform;

        navMesh = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


    public void goAndFollow()
    {
        //Debug.Log("ide");
        navMesh.enabled = true;
        navMesh.SetDestination(playerTransform.position);
        mng.animator.SetBool("Run", true);
    }

    public void stop()
    {
        //Debug.Log("stoje");
        navMesh.enabled = false;
        mng.animator.SetBool("Run", false);
    }
}
