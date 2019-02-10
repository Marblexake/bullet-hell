using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Vector3 mousePos;
    private Vector3 worldPos;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        //References the position of the mouse in the game
        mousePos = Input.mousePosition;

        //This gets the mouse's position in relation to world space
        worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        //Sets the transform of this GameObject to the world position of the mouse
        transform.position = worldPos;
    }
}
