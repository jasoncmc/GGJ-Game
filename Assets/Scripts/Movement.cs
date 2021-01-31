using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movespeed = 2f;
    // Start is called before the first frame update
    Rigidbody2D rb;
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        rb.freezeRotation = true;
        //rb.velocity = new Vector2(0, 0);
        rb.gravityScale = 0;
   
        rb.MovePosition((Vector2)transform.position + (Vector2.right * movespeed * Time.deltaTime));
    }
}
