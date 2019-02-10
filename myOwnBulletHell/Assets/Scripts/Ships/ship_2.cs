using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_2 : MonoBehaviour {

    private float delta = 2.4f;
    private float xValue;
    private float xTime;

    private Vector3 position;

    // Use this for initialization
    void Start () {

        //transform.position = new Vector3(-1, 0, 0);
        position = new Vector3(0, 8, 0);
	}
	
	// Update is called once per frame
	void Update () {

        //interpolates between delta and -delta in a nice curve, just like on the sine graph
        //The 2f inside the Sin is the speed
        position.x = delta * Mathf.Sin(xTime);
        transform.position = position;

        xTime += Time.deltaTime;


	}
}
