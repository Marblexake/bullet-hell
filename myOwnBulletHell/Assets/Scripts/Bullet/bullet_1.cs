using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_1 : MonoBehaviour {

    public float speed = 4f;

	// Update is called once per frame
	void Update () {
        transform.position += transform.up * speed * Time.deltaTime;
	}
}
