using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHolder : MonoBehaviour
{
    public string text;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InfoTextManager TM = other.GetComponent<InfoTextManager>();
            TM.SetText(text);
            TM.ShowText(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InfoTextManager TM = other.GetComponent<InfoTextManager>();
            TM.SetText("");
            TM.ShowText(false);
        }
    }

}
