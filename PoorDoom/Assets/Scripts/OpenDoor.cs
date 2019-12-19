using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private void Update()
    {
        if (PlayerMovement.coins == 0)
        {
            Debug.Log("ołpen");
            Destroy(gameObject);
        }
    }
}
