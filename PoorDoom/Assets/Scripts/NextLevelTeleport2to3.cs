using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTeleport2to3 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Want go");
            if (other.gameObject.GetComponent<KeyCollector>().haveKey == true)
            {
                Debug.Log("Teleport");
                SceneManager.LoadScene(4);
            }

        }
    }
}
