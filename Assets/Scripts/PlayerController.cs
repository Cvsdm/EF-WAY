using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        /* 
         Computer, not Android   
        */ float moveHorizontal = Input.GetAxis("Horizontal");
         float moveVertical = Input.GetAxis("Vertical");

         Vector3 movement = new Vector3(moveHorizontal, 0.0f , moveVertical);
        

        /* Android 

        Vector3 acceleration = Input.acceleration;

        Vector3 movement = new Vector3(acceleration.x, 0.0f , acceleration.y);
        */
        rb.AddForce(movement * speed);
    }

}
