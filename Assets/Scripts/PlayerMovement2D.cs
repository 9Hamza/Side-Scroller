using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    // Because we want our player to move left and right, we will be coding movement using a Vector2 instead of a Vector3.
    // As you can see, an Orthographic view condenses the world into a flat picture. There is no depth, everything is evenly sized. (Can be found in the camera > projection > orthographic)
    // If we want our camera to see more of the world, we need to change its Size.
    
    [SerializeField] private float speed;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal") * speed, 0);

        // using x from input & y from the rigidbody (so it can be pulled down)
        _rb.velocity = new Vector2(movement.x, _rb.velocity.y);
    }
}
