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
        chooseSpawnRate();
        Debug.Log(number);
    }

    void chooseSpawnRate()
    {
        number = Random.Range(1, 4);

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
            spawnedBullet = Instantiate(missile2, gameObject.transform.position, gameObject.transform.rotation);
            spawnedBullet.transform.parent = gameObject.transform;
            spawnedBullet.transform.parent = null;
            //chooseSpawnRate();

            yield return new WaitForSeconds(spawnrate);
        }

    }

}