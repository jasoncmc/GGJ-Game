using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movespeed = 10f;
    // Start is called before the first frame update
    Rigidbody2D rb;
    PlayerController pc;
    void Start()
    {
        // movespeed = Random.Range(0, 10);
        rb = GetComponent<Rigidbody2D>();
        pc = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.freezeRotation = true;
        //rb.velocity = new Vector2(0, 0);
        rb.gravityScale = 0;
        //GetComponent<BoxCollider2D>().sharedMaterial = null;

        //transform.position = new Vector3(transform.position.x + movespeed, transform.position.y, -1);
        if(!pc.moveAllowed)
        {
            rb.MovePosition((Vector2)transform.position + (Vector2.right * movespeed * Time.deltaTime));
        }

        //need to destroy when sheep reach a certain range 


    }
}
