using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLevel1 : MonoBehaviour {

    public GameObject yellowBullet;

    private GameObject spawnedBullet;

	// Use this for initialization
	void Start () {

        StartCoroutine(spawnBullets());

	}
	
	// Update is called once per frame
	void Update () {

        //spawnedBullet = Instantiate(yellowBullet, gameObject.transform.position, gameObject.transform.rotation);

        //spawnedBullet.transform.parent = gameObject.transform;

        //spawnedBullet.transform.parent = null;


	}

    IEnumerator spawnBullets()
    {
        for(; ; )
        {
            spawnedBullet = Instantiate(yellowBullet, gameObject.transform.position, gameObject.transform.rotation);

            spawnedBullet.transform.parent = gameObject.transform;

            spawnedBullet.transform.parent = null;

            yield return new WaitForSeconds(0.15f);
        }
        
    }





}
