using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedMove = 10;
    private float gravityForce;
    private Vector3 moveVector;

    private CharacterController characterController;
    private MobileController mobileController;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
        mobileController = GameObject.FindGameObjectWithTag("Joystick").GetComponent<MobileController>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMove();
        GamingGravity();
    }

    void CharacterMove()
    {
        moveVector = Vector3.zero;
        moveVector.x = mobileController.Horizontal() * speedMove;
        moveVector.z = mobileController.Vertical() * speedMove;

        moveVector.y = gravityForce;
        characterController.Move(moveVector * Time.deltaTime);
    }

    public void GamingGravity()
    {
        if (!characterController.isGrounded)
        {
            gravityForce -= 20f * Time.deltaTime;
        }
        else
        {
            gravityForce = -1f;
        }
    }
}
