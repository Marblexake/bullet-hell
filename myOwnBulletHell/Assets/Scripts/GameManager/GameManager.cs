using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject Ship1;
    public GameObject Ship2;
    public GameObject Ship3;

    private GameObject ship11;
    private GameObject ship22;
    private GameObject ship33;

    private bool Ship1_made;
    private bool Ship2_made;
    private bool Ship3_made;

	void Start () {
        //Spawns the first "level"/ship
        createShip1();
	}
	
	void Update () {
        //Checks if 10 seconds has passed, if so, spawn the next "level"/ship and destroy the one already in the scene
        if(Time.time > 10)
        {
            createShip2();
            Destroy(ship11);
        }
        //Checks if 10 seconds has passed, if so, spawn the next "level"/ship and destroy the one already in the scene
        if (Time.time > 20)
        {
            createShip3();
            Destroy(ship22);
        }
        //After 30 seconds, destroy the last ship
        if(Time.time > 30)
        {
            Destroy(ship33);
        }

	}

    void createShip1()
    {
        //Checks if the ship is already in the scene
        if (!Ship1_made)
        {
            ship11 = Instantiate(Ship1);
            Ship1_made = true;
        }
    }

    void createShip2()
    {
        //Checks if the ship is already in the scene
        if (!Ship2_made)
        {
            ship22 = Instantiate(Ship2);
            Ship2_made = true;
        }
    }

    void createShip3()
    {
        //Checks if the ship is already in the scene
        if (!Ship3_made)
        {
            ship33 = Instantiate(Ship3);
            Ship3_made = true;
        }
    }

}
