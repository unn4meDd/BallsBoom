using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speedMove = 10;
    private Vector3 moveVector;
    private Rigidbody rigidBody;
    private MobileController mobileController;

    // Start is called before the first frame update
    void Start()
    {
    	rigidBody = GetComponent<Rigidbody>();
        mobileController = GameObject.FindGameObjectWithTag("Joystick").GetComponent<MobileController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Lose();
    }

    void Move()
    {
        moveVector = Vector3.zero;
        moveVector.x = mobileController.Horizontal();
        moveVector.z = mobileController.Vertical();
        Vector3 movement = new Vector3(moveVector.x, 0.0f, moveVector.z);
        rigidBody.AddForce(movement * speedMove);
    }
    void Lose()
    {
        if(gameObject.transform.position.y <= -3)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
