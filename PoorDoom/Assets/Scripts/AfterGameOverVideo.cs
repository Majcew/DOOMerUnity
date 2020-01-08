using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterGameOverVideo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitSec(6f));
    }

    private IEnumerator WaitSec(float value)
    {
        yield return new WaitForSeconds(value);
        SceneManager.LoadScene(0);
    }
}
