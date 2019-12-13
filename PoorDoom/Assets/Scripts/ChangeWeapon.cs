using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    [Header("Add the weapons")]
    public GameObject[] weaponobj;
    [Header ("The state of the weapons")]
    public bool[] isActive;

    private void Awake()
    {
        foreach (GameObject obj in weaponobj)
        {
            obj.SetActive(false);
        }
        foreach (bool value in isActive)
        {
            value.Equals(false);
        }
        weaponobj[1].SetActive(true);
        isActive[1] = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && !isActive[0])
        {
            ImportantFunction(0);
            weaponobj[0].SetActive(true);
            isActive[0] = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) && isActive[0])
        {
            ImportantFunction(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && !isActive[1])
        {
            ImportantFunction(1);
            weaponobj[1].SetActive(true);
            isActive[1] = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && isActive[1])
        {
            ImportantFunction(1);
        }
    }
    void ImportantFunction(int index)
    {
        foreach(GameObject elem in weaponobj)
        {
            elem.SetActive(false);
        }
        for(int i = 0;i<isActive.Length;i++)
        {
            isActive[i] = false;
        }
    }
}
