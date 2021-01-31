using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnee;
    public GameObject spawnee2;
    public GameObject spawnee3;
    public GameObject spawnee4;
    public GameObject spawnee5;

    public float spawnTime;
    public bool spawnFlag = false;
    public bool spawnAlt = false;
    public int spawnDelay;
    public int randgen; 
    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = Random.Range(15, 25);
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);

    }
    public void SpawnObject()
    {
        randgen = Random.Range(1, 6);
        if (randgen == 1)
        {
            var bumper = (GameObject)Instantiate(spawnee2, transform.position, transform.rotation);
            spawnAlt = false;
        }
        else if(randgen == 2)
        {
            var bumper = (GameObject)Instantiate(spawnee, transform.position, transform.rotation);
            spawnAlt = true;
        }
        else if (randgen == 3)
        {
            var bumper = (GameObject)Instantiate(spawnee3, transform.position, transform.rotation);
            spawnAlt = true;
        }
        else if (randgen == 4)
        {
            var bumper = (GameObject)Instantiate(spawnee4, transform.position, transform.rotation);
            spawnAlt = true;
        }
        else if (randgen == 5)
        {
            var bumper = (GameObject)Instantiate(spawnee5, transform.position, transform.rotation);
            spawnAlt = true;
        }

        if (spawnFlag)
        {
            CancelInvoke("SpawnObject");
        }
       
    }
}
