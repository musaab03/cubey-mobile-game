using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //Ints and Floats
    public float moveSpeed;
    float maxSpeed = 5f;

    //Components
    public Rigidbody rb;
    Vector3 input;
    public bl_Joystick VirtualJoystick;

    void Start ()
    {
        rb = rb.GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
    {
        input = new Vector3(VirtualJoystick.Horizontal, 0, VirtualJoystick.Vertical);

        //Movement
        if(rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(input * moveSpeed);
        }
	}
}
