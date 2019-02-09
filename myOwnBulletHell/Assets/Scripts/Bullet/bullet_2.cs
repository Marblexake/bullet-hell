using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_2 : MonoBehaviour {

    public GameObject invertedBullet;
    public float distance = 1.4f;
    public float speed = 8f;

    private float StartTime;
    private float CreationTime;
    private GameObject spawnedBullet;

	// Use this for initialization
	void Start ()
    {
        //Tracks when the bullet was instantiated
        StartTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        //Moves the bullet downwards.
        transform.position += transform.up * -speed * Time.deltaTime;

        CheckTime();

        if(CreationTime > distance)
        {
            explode();
            Destroy(gameObject);
        }
	}

    public void CheckTime()
    {
        //Gets the length of time this bullet has existed in the scene
        CreationTime = Time.time - StartTime;
    }

    public void explode()
    {
        spawnedBullet = Instantiate(invertedBullet, gameObject.transform.position, gameObject.transform.rotation);
        spawnedBullet.transform.Rotate(0, 0, 180);
    }
}
