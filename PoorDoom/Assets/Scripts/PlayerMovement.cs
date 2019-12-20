﻿using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour {

    public float playerWalkingSpeed = 5f;
    public float playerRunningSpeed = 15f;
    public float jumpStrength = 20f;
    public float verticalRotationLimit = 80f;
    public DiamondCollector diamonds;

    float forwardMovement;
    float sidewaysMovement;

    float verticalVelocity;

    float verticalRotation = 0;
    CharacterController cc;

    void Awake()
    {
        cc = GetComponent<CharacterController>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        diamonds = GetComponent<DiamondCollector>();
    }

    public void CollectCoin()
    {
        diamonds.AddDiamond();
        Debug.Log(diamonds.GetDiamondsAmount());
    }

    void LateUpdate()
    {
        //Rozglądanie się na boki
        float horizontalRotation = Input.GetAxis("Mouse X");
        transform.Rotate(0, horizontalRotation, 0);

        //Rozglądanie się góra dół
        verticalRotation -= Input.GetAxis("Mouse Y");
        verticalRotation = Mathf.Clamp(verticalRotation, -verticalRotationLimit, verticalRotationLimit);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        //Poruszanie graczem
        //Tylko jeśli ma kontakt z podłożem
        if (cc.isGrounded)
        {
            forwardMovement = Input.GetAxis("Vertical") * playerWalkingSpeed;
            sidewaysMovement = Input.GetAxis("Horizontal") * playerWalkingSpeed;
            //Bieganie jeśli gracz wcisnął Lewy Shift
            if (Input.GetKey(KeyCode.LeftShift))
            {
                forwardMovement = Input.GetAxis("Vertical") * playerRunningSpeed;
                sidewaysMovement = Input.GetAxis("Horizontal") * playerRunningSpeed;
            }
        }else { verticalVelocity += Physics.gravity.y * Time.deltaTime; }
        // Sprawienie, aby na gracza działała grawitacja
        // A więc, żeby podłoże go przyciągało
        //verticalVelocity += Physics.gravity.y * Time.deltaTime;

        //Skakanie po wciśnięciu przycisku odpowiedzialnego za skok
        if (Input.GetButton("Jump") && cc.isGrounded)
        {
            verticalVelocity = jumpStrength;
        }

        Vector3 playerMovement = new Vector3(sidewaysMovement, verticalVelocity, forwardMovement);
        //Poruszanie bohaterem
        cc.Move(transform.rotation * playerMovement * Time.deltaTime);
    }
}
