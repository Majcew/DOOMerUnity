using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{
    public void PlayGame()
    {
        EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Options()
    {
        Debug.Log("Options");
        SceneManager.LoadScene(5);
    }

    public void EndGame()
    {
        Debug.Log("Let's see if it quits");
        Application.Quit();
    }
}
