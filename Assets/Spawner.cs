using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnee;
    public float spawnTime;
    public bool spawnFlag = false;
    public float spawnDelay; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        
    }
    public void SpawnObject()
    {
        Instantiate(spawnee, transform.position, transform.rotation);
        if (spawnFlag)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
