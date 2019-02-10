using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLevel3 : MonoBehaviour {

    //155 - 205
    //Spawner3

    public GameObject blueBullet;

    public float spawnrate = 0.05f;
    public float seconds = 0.15f;
    public float delta = 0.6f;
    public float speed = 3f;
    public float startingAngle = 155f;


    private float t;
    private GameObject spawnedBullet;
    private float angle;

	// Use this for initialization
	void Start () {
        //Sets the initial rotation
        transform.Rotate(0, 0, startingAngle);
        StartCoroutine(FireBullets());
	}
	
	// Update is called once per frame
	void Update () {
        //Determines how much the spawner rotates, making the spawner rock left to right nicely
        angle = delta * Mathf.Sin(t * speed);
        transform.Rotate(0, 0, angle);

        t += Time.deltaTime;
    }

    IEnumerator FireBullets()
    {
        for(; ; )
        {
            //Spawns the bullet where the spawner is, then unparents the bullet for it to move freely
            spawnedBullet = Instantiate(blueBullet, gameObject.transform.position, gameObject.transform.rotation);
            spawnedBullet.transform.parent = null;
        
            yield return new WaitForSeconds(spawnrate);

        }
    }
}
