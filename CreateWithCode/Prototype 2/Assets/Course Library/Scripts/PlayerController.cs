using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
public float horizontalInput;
public float speed = 15f;
public float xRange = 20.0f;


    // Update is called once per frame
    void Update()
    {
    if(transform.position.x < -xRange)
    {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }
    
    if(transform.position.x > xRange)
    {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }
    
        //i(transform.position.x < -10)
        //{
        //transform.position = new Vector3()
        //}
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        
    }
}
