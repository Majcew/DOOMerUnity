using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyTeleport : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("test");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("test2");
            EditorSceneManager.LoadScene(2);
        }
    }
}
