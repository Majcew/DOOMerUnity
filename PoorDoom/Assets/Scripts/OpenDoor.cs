using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public DiamondCollector diamondCollector;
    public GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        diamondCollector = player.GetComponent<DiamondCollector>();
    }

    private void Update()
    {
        if (diamondCollector.allDiamondsTaken == true)
        {
            Debug.Log("ołpen");
            Destroy(gameObject);
        }
    }
}
