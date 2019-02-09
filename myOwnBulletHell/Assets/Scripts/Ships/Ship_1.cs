using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_1 : MonoBehaviour {

    private float delta = 0.65f;
    private float zValue;
    private float ztime;

	// Use this for initialization
	void Start ()
    {
        //sets the inital rotation of the ship
        transform.Rotate(0, 0, -50);

	}
	
	// Update is called once per frame
	void Update () {

        //interpolates between delta and -delta
        zValue = delta * Mathf.Sin(ztime);

        //Debug.Log(Mathf.Sin(ztime)); Delta controls how much the ship rotates

        //applies the rotation 
        transform.Rotate(0, 0, zValue);

        //
        ztime += Time.deltaTime;

    }


}
