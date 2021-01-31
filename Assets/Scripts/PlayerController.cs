using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    float deltaX, deltaY;
    Rigidbody2D rb;
    public float rotationSpeed = 160f;

    public bool moveAllowed = false;
    public bool hasAnimal = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0) // if there are any touches on screen
        {
            Touch touch = Input.GetTouch(0); //Get the first touch input
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);//converts the touch input into world space coords
            Vector2 originalPos = transform.position;

            switch (touch.phase) // if screen is touched
            {
                case TouchPhase.Began:

                    if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPosition) &&!hasAnimal) //if animal is touched
                    {
                        //get ofset of the position of the touch and the gameobject
                        deltaX = touchPosition.x - transform.position.x;
                        deltaY = touchPosition.y - transform.position.y;

                        moveAllowed = true;

                        //restric rigidbody properties so it moves smoothly
                        rb.freezeRotation = false;
                        rb.velocity = new Vector2(0, 0);
                        rb.gravityScale = 0;
                        //GetComponent<BoxCollider2D>().sharedMaterial = null;
                        hasAnimal = true;
                    }
                    break;
                case TouchPhase.Moved: //if finger is moved

                    if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPosition) && moveAllowed) //if animal is touched and movement is allowed
                    {
                        Vector2 pointToObject = new Vector2(touchPosition.x - deltaX, touchPosition.y - deltaY);

                        if(pointToObject.x > transform.position.x)
                        {
                            rb.AddTorque(Vector2.Dot(Vector2.down, pointToObject) * rotationSpeed * Time.deltaTime); //rotate right
                        }
                        else
                        {
                            rb.AddTorque( Vector2.Dot(Vector2.up,pointToObject) * rotationSpeed * Time.deltaTime); //rotate left
                        }
                        transform.position = originalPos;
                    }
                    break;
                case TouchPhase.Ended: //if finger is released

                    //restore initial parameters
                    hasAnimal = false;
                    moveAllowed = false;
                    rb.freezeRotation = true;
                    transform.position = originalPos;
                    //GetComponent<BoxCollider2D>().sharedMaterial = new PhysicsMaterial2D();
                    break;
            }
        }
    }
   
}
