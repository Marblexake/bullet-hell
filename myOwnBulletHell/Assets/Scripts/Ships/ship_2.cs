using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_2 : MonoBehaviour {

    private float delta = 7f;
    private float xValue;
    private float xTime;

    private Vector3 position;

    // Use this for initialization
    void Start () {

        position = new Vector3(0, 6, 0);
	}
	
	// Update is called once per frame
	void Update () {

        position.x = delta * Mathf.Sin(xTime);

        transform.position = position;

        xTime += Time.deltaTime;


	}
}
