using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Options()
    {
        SceneManager.LoadScene(5);
    }

    public void Authors()
    {
        SceneManager.LoadScene(6);
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
