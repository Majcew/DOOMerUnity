using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoTextManager : MonoBehaviour
{
    public Text InfoText;
    public GameObject InfoTextPlace;


    void Start()
    {
        InfoText.text = "";
        InfoTextPlace.SetActive(false);
    }

    public void SetText(string text)
    {
        InfoText.text = text;
    }

    public void ShowText(bool state)
    {
        InfoTextPlace.SetActive(state);
    }

}
