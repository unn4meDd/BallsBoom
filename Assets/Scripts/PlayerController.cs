using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedMove = 10;
    private Rigidbody rigidBody;
    private MobileController mobileController;
    float gravityForce;

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
        GamingGravity();
    }

    void Move()
    {
        float moveVertical = mobileController.Vertical();
        float moveHorizontal = mobileController.Horizontal();
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rigidBody.AddForce(movement * speedMove);
    }
    void GamingGravity()
    {
        if(gameObject.transform.position.y <= -3)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
