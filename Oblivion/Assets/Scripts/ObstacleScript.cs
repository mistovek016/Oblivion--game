using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float speed;

    public int damage = 1;

    public GameObject asteroidefect;

    private Animator animator;

    

    private void OnTriggerEnter2D(Collider2D  other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().health -= damage;
            other.GetComponent<PlayerMovement>().healthBar.SetHealth(other.GetComponent<PlayerMovement>().health);
            //Debug.Log(other.GetComponent<PlayerMovement>().health);
            
            animator.Play("Asteroid-1-Breaking");
  
        }

        



    }

    private void Update()
    {
        animator = gameObject.GetComponent<Animator>();
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (gameObject.transform.position.y < -5.5)
        {
            
            Destroy(gameObject);
        }
    }
}
