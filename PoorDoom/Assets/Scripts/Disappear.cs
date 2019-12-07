using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("test");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("test2");
            Destroy(gameObject);
        
        }

        
    }
}
