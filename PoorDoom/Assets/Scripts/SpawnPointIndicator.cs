using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointIndicator : MonoBehaviour
{

    public GameObject player;
    public bool ready = false;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            ready = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            ready = false;
        }
    }
}
