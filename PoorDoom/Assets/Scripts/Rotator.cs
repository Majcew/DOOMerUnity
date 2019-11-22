using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    Rigidbody rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        rbody.AddTorque(new Vector3(0,90,0));
    }

}
