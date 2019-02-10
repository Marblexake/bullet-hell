using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLevel1 : MonoBehaviour
{

    public GameObject yellowBullet;

    private GameObject spawnedBullet;
    private float spawnrate = 0.1f;

	void Start ()
    {
        StartCoroutine(spawnBullets());

	}
	void Update ()
    {

	}

    IEnumerator spawnBullets()
    {
        for(; ; )
        {
            spawnedBullet = Instantiate(yellowBullet, gameObject.transform.position, gameObject.transform.rotation);
            //spawnedBullet.transform.parent = gameObject.transform;
            spawnedBullet.transform.parent = null;

            yield return new WaitForSeconds(spawnrate);
        }
        
    }

}
