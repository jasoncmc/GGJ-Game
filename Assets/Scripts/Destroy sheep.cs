using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroysheep : MonoBehaviour
{
    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 5);
    }
    // Start is called before the first frame update
    void Start()
    {
        DestroyObjectDelayed();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
