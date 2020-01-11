using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowKeyAfterTakeAllDiaments : MonoBehaviour
{
    public DiamondCollector diamondCollector;
    public GameObject player;
    private bool oneRun = false;
    public GameObject key;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        diamondCollector = player.GetComponent<DiamondCollector>();
        key.SetActive(false);
    }

    private void Update()
    {
        if (diamondCollector.allDiamondsTaken == true)
        {
            if(oneRun == false)
            {
                Debug.Log("Key unlocked!");
                key.SetActive(true);
                oneRun = true;
            }

        }

    }

}
