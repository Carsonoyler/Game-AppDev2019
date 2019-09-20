using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	// Player control private variables 
    private float speed = 20f;

    private float turnSpeed = 15f;

    private float horizontalInput;

    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
    	// This code moves the vehicle forward and back, left and right.
    	horizontalInput = Input.GetAxis("Horizontal"); 
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
