using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 2f;

    private static Rigidbody2D rb;

    public int health = 6;

    public int currentHealth;

    public int Maxhealth;

    Vector2 movement;

    public Text healthDisplay;

    public GameObject gameOver;

    public HealthBar healthBar;

    //public GameObject effect;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        currentHealth = Maxhealth;
        healthBar.SetMaxHealth(Maxhealth);
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = health.ToString();

        //Input
        
        movement.x = Input.GetAxisRaw("Horizontal");
        

        if (health <= 0)
        {

            gameOver.SetActive(true);
            Destroy(gameObject);

        }
        
    }

   
    private void FixedUpdate()
    {
        //Movement
        // Particle System trial (down)
        //Instantiate(effect, transform.position, Quaternion.identity);
        rb.MovePosition(rb.position + movement * movespeed);
    }
}
