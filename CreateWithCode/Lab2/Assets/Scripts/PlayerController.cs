using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float speed = 10.0f;
    private Rigidbody playerRb;
    public float horizontalInput;
    public float xRange = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        //Adds rigidBody to the player
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Makes the player move ledt and right, but not go off screen
         if(transform.position.x < -6)
        {
            transform.position = new Vector3(-6, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 17)
        {
            transform.position = new Vector3(17, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
    }
}
