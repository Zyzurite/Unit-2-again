using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float speed = 15;
    private Rigidbody rb;
    public bool LR = false;
    public bool FB = false;
    private float x;
    private float z;

    Vector3 velocity;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        PlayerMover();
    }

    void PlayerMover()
    {
        // Turn player based on mouse movement

        // Move player based on keyboard presses

        if (LR == true)

        {
            x = Input.GetAxis("Horizontal");
        }
        if (FB == true)
        { 
            z = Input.GetAxis("Vertical");
        }

        
        Vector3 move = new Vector3(x, 0f, z);
        rb.AddForce(move * speed);
    }

}
