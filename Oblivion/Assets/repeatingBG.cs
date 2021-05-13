using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingBG : MonoBehaviour
{
    public float speed;

    public float EndY;
    public float StartY;

    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y <= EndY)
        {
            Vector2 pos = new Vector2(transform.position.x, StartY);
            transform.position = pos;
        }
    }
}
