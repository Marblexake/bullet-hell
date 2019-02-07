using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLevel1 : MonoBehaviour {

    public int nBullets = 10;
    public GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        bullet = Instantiate(bullet);

	}
}
