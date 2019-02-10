using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_3 : MonoBehaviour {

    private float delta = 0.7f;
    private float zValue;
    private float ztime;

    // Use this for initialization
    void Start()
    {
        //sets the inital rotation of the ship
        transform.Rotate(0, 0, -50);
    }

    // Update is called once per frame
    void Update()
    {

        //interpolates between delta and -delta in a nice curve, just like on the sine graph
        //the 2f is the speed
        zValue = delta * Mathf.Sin(ztime * 2f);

        //Debug.Log(Mathf.Sin(ztime)); Delta controls how much the ship rotates.

        //applies the rotation 
        transform.Rotate(0, 0, zValue);
        ztime += Time.deltaTime;

    }

}
