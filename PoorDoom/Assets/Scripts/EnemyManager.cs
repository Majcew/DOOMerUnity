using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    //tablica spawnpointów, manadżer zarządza nimi wszystkimi
    public Transform[] spawnPoints;
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Spawn()
    {
        if (playerHealth.health <= 0 || PlayerMovement.coins == 3)
            return;
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position,
            spawnPoints[spawnPointIndex].rotation); 
    }
}
