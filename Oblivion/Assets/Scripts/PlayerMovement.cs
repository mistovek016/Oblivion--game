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

    public GameObject ScoreManager;

    Vector2 movement;

    public Text Healthdisplay;

    public GameObject gameOver;

    public HealthBar healthBar;

    /*public SpriteRenderer blobRenderer;

    public BoxCollider2D Collider;

    public bool shieldControl;

    public GameObject transperantBlob;*/

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        currentHealth = Maxhealth;
        
        healthBar.SetMaxHealth(Maxhealth);

        //shieldControl = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        Healthdisplay.text = health.ToString();


        //Input

        movement.x = Input.GetAxisRaw("Horizontal");


        if (health <= 0)
        {

            gameOver.SetActive(true);
            Destroy(gameObject);
            Destroy(ScoreManager);


        }

        /*if (Input.GetKey(KeyCode.Space))
        {

            blobRenderer.color = new Color (1, 1, 1, 0);
            Collider.enabled = false;

            Invoke("ShieldDisable", 5);

            //yield return new WaitForSeconds(5);
            //shieldControl = false;
            //blobRenderer.color = new Color(1, 1, 1, 1);
        }

        if (shieldControl == false)
        {

            Destroy(transperantBlob);

        }
    }

    public void ShieldDisable()
    {

        shieldControl = false;
        blobRenderer.color = new Color(1, 1, 1, 1);
        Collider.enabled = true;
        

    }*/

    }
   
    private void FixedUpdate()
    {
        //Movement
        // Particle System trial (down)
        //Instantiate(effect, transform.position, Quaternion.identity);
        rb.MovePosition(rb.position + movement * movespeed);
    }
}
