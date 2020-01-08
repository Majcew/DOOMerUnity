using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCollector : MonoBehaviour
{
    public GameObject KeyIndicator;
    public bool haveKey = false;

    public void TakeKey()
    {
        haveKey = true;
        KeyIndicator.SetActive(true);
    }

    public void Update()
    {
        if(haveKey==false)
        {
            KeyIndicator.SetActive(false);
        }
        else
        {
            KeyIndicator.SetActive(true);
        }
    }

    public void GiveKey()
    {
        haveKey = false;
        KeyIndicator.SetActive(false);
    }
}
