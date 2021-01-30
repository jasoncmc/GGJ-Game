using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movespeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
       // movespeed = Random.Range(0, 10);


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + movespeed, transform.position.y, -1);
        
        //need to destroy when sheep reach a certain range 


    }
}
