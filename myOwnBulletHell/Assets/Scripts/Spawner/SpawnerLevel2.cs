using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLevel2 : MonoBehaviour
{

    public GameObject missile2;
    public float spawnrate;

    private GameObject spawnedBullet;
    private float number;

    void Start()
    {
        StartCoroutine(spawnBullets());

    }

    void Update()
    {
        //This allows the missiles to be shot randomly
        chooseSpawnRate();
    }

    void chooseSpawnRate()
    {
        //Generates a random int between 1-4, 1 inclusive, 4 exclusive
        number = Random.Range(1, 4);

        //Based on whatever number was picked, change the spawnrate
        if (number == 1)
        {
            spawnrate = 0.5f;
        }
        if(number == 2)
        {
            spawnrate = 0.35f;
        }
        if(number == 3)
        {
            spawnrate = 0.2f;
        }
    }

    IEnumerator spawnBullets()
    {
        for (; ; )
        {
            //Spawns the missile where the spawner is, then unparent the bullet for free movement.
            spawnedBullet = Instantiate(missile2, gameObject.transform.position, gameObject.transform.rotation);
            spawnedBullet.transform.parent = null;

            yield return new WaitForSeconds(spawnrate);
        }

    }

}