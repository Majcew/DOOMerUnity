using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    //tablica spawnpointów, manadżer zarządza nimi wszystkimi
    public Transform spawnPointsHolder;
    public List<Transform> spawnPoints = new List<Transform>();
    private SpawnPointIndicator ready;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        foreach (Transform child in spawnPointsHolder)
        {
            spawnPoints.Add(child);
        }
        Debug.Log(spawnPoints.Count + " spawn points detected");
    }

    // Update is called once per frame
    void Spawn()
    {
        if (playerHealth.health <= 0)
            return;

        foreach (Transform spawnPoint in spawnPoints)
        {
            ready = spawnPoint.GetComponent<SpawnPointIndicator>();
            if(ready.ready == true)
            {
                Instantiate(enemy, spawnPoint.position,
                    spawnPoint.rotation);
            }


        }

    }
}
