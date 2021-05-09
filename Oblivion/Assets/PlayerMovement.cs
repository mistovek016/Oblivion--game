using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 2f;

    private static Rigidbody2D rb;

    Vector2 movement;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

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
