using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    
    private Rigidbody _rb;
    private bool _canJump = true;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool grounded = Physics.Linecast(transform.position, groundCheck.position, groundLayer);
        
        Debug.DrawLine(transform.position, groundCheck.position, Color.red);

        if (grounded)
        {
            _canJump = true;
        }
        else
        {
            _canJump = false;
        }
        Jump();
    }

    // You can adjust the gravity from the project settings if jumping looks weird for the player
    private void Jump()
    {
        // GetButton = The code is called for every single frame that the button is held down.
        // GetButtonDown = The code is called only once, the moment the button is pressed down.
        if (Input.GetButtonDown("Jump") && _canJump)
        {
            _canJump = false;
            _rb.AddForce(Vector3.up * jumpForce);
        }
    }
}
