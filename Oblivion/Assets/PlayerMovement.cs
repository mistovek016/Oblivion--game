using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 2f;

    public Rigidbody2D rb;

    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        
    }

    private void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * movespeed);
    }
}
