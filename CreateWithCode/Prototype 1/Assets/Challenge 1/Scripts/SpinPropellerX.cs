using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
	private float rotationSpeed = 200f;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed); 
    }
}
