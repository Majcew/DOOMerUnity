using UnityEngine;

public class OpenDoorToExitRoom : MonoBehaviour
{
    public GameObject player;
    public GameObject boss;
    public PlayerMovement pm;
    public GameObject doorToExitRoom;
    public BossHealth bossHealth;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pm = player.GetComponent<PlayerMovement>();
        bossHealth = boss.GetComponent<BossHealth>();
    }

    private void Update()
    {
        if (bossHealth.isDead == true && pm.inBossRoom==true)
        {
            Debug.Log("open door to exit room");
            doorToExitRoom.SetActive(false);
            //Destroy(gameObject);
        }

    }
}
