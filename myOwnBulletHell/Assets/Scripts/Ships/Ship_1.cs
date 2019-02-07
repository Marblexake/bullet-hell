using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_1 : MonoBehaviour {

    private float amplitude = 0.45f;
    private float zValue;
    private float ztime;

	// Use this for initialization
	void Start ()
    {

        transform.Rotate(0, 0, -60);

	}
	
	// Update is called once per frame
	void Update () {

        zValue = amplitude * Mathf.Sin(ztime);
        Debug.Log(zValue);
        transform.Rotate(0, 0, zValue);
        ztime += Time.deltaTime;

    }


}
