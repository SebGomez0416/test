using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movement;    

    [SerializeField] private float moveForce;
    [SerializeField] private float jumpForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal") *moveForce;

        if(Input.GetButtonDown("Jump"))
            rb.AddForce(Vector3.up* jumpForce, ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        rb.AddForce(movement,ForceMode.Acceleration);        
    }
}
