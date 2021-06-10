using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    public SpriteRenderer blobRenderer;

    public BoxCollider2D Collider;

    public bool shieldControl;

    public GameObject transperantBlob;

    // Start is called before the first frame update

    void Start()
    {
        shieldControl = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {

            blobRenderer.color = new Color(1, 1, 1, 0);
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


    }

}


