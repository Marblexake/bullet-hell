using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_1 : MonoBehaviour {

    public float speed = 4f;
    private float MaxTimeInScene = 4.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        //Just moves the bullet in a straight line on its Y-axis (the yellow line)
        transform.position += transform.up * speed * Time.deltaTime;

        //Destroys the bullet after 10 seconds
        Destroy(gameObject, MaxTimeInScene);
	}

}
