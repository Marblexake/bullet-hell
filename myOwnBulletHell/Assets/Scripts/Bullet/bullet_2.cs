using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_2 : MonoBehaviour {

    public GameObject invertedBullet;

    //*How long bullet has been in scene* Because the longer the bullet is in scene, the further it travels
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

        //Distance here contraints how long the bullet has existed in the scene
        if(CreationTime > distance)
        {
            explode();

            //If bullet has been in scene long enough, destroy it
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
        //Spawns the inverted bullet at this GameObject Pos
        spawnedBullet = Instantiate(invertedBullet, gameObject.transform.position, gameObject.transform.rotation);

        //Flips the inverted bullet around
        spawnedBullet.transform.Rotate(0, 0, 180);
    }
}
