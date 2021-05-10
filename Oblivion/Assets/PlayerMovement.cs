using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 2f;

    private static Rigidbody2D rb;

    public int health = 6;

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

        if (health <= 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        
    }

    private void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * movespeed);
    }
}
