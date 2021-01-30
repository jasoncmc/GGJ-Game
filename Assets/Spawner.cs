using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnee;
    public GameObject spawnee2;
    public float spawnTime;
    public bool spawnFlag = false;
    public bool spawnAlt = false;
    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);

    }
    public void SpawnObject()
    {
        if (spawnAlt)
        {
            var bumper = (GameObject)Instantiate(spawnee2, transform.position, transform.rotation);
            spawnAlt = false;
        }
        else
        {
            var bumper = (GameObject)Instantiate(spawnee, transform.position, transform.rotation);
            spawnAlt = true;
        }
        if (spawnFlag)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
