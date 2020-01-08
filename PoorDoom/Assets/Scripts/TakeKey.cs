using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKey : MonoBehaviour
{
    private GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player = other.gameObject;
            player.GetComponent<KeyCollector>().TakeKey();
            Destroy(gameObject);
        }
    }
}
