using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLevel3 : MonoBehaviour {

    //155 - 205
    public GameObject blueBullet;
    public float rotateMin;
    public float rotateMax;
    public float spawnrate;

    private GameObject spawnedBullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RotateSpawner();
	}

    void RotateSpawner()
    {
        transform.Rotate(0, 0, 10);
    }
}
