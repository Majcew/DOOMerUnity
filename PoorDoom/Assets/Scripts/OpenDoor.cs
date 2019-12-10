using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private void Update()
    {
        if (PlayerMovement.coins == 3)
        {
            Debug.Log("ołpen");
            Destroy(gameObject);
        }
    }
}
