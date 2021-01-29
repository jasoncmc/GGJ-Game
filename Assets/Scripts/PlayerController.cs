using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0) // if there are any touches on screen
        {
            Touch touch = Input.GetTouch(0); //Get the first touch input
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);//converts the touch input into world space coords

            touchPosition.z = 0.0f;
            transform.position = touchPosition; 
        }
    }
   
}
