using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyTeleport : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}
