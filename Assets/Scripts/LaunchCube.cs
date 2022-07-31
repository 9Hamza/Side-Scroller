using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
        rb.AddForce(Vector3.up * 500); // Vector3.up is the up direction based on the world space
        rb.AddForce(transform.forward * 500); // the cube is pushed towards its own forward-facing direction
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
