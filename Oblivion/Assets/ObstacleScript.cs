using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float speed;

    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D  other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().health -= damage;
            Debug.Log(other.GetComponent<PlayerMovement>().health);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
