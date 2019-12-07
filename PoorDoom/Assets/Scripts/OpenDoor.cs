using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(PlayerMovement.coins ==3)
            {
                Destroy(gameObject);
            }
        }
    }
}
