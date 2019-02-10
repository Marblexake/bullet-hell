using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLevel1 : MonoBehaviour
{

    public GameObject yellowBullet;

    private GameObject spawnedBullet;
    public float spawnrate = 0.1f;

	void Start ()
    {
        StartCoroutine(spawnBullets());
	}


    IEnumerator spawnBullets()
    {
        //This causes the loop to run infinitely
        for(; ; )
        {
            //Spawns the bullet at where the spawner is, and then unparent them so that the bullet can move freely
            spawnedBullet = Instantiate(yellowBullet, gameObject.transform.position, gameObject.transform.rotation);
            spawnedBullet.transform.parent = null;

            //Determines how often the spawner spawns
            yield return new WaitForSeconds(spawnrate);
        }
        
    }

}
