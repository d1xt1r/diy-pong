﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 10;
    Rigidbody2D ballRigidbody; // Variable for the reference of the Rigidbody of the ball
    Vector2 spawnDirection; // Variable for the random spawn direction

    // Use this for initialization
    void Start () {
        ballRigidbody = GetComponent<Rigidbody2D>(); // Reference to the Rigidbody of the ball
        //ballRigidbody.AddForce(new Vector2(5 * force, force));

        int randomBallPosition = Random.Range(1, 5); // Generate random number from 1 to 4 and based on this random number spawn the ball at the following vectors

        if (randomBallPosition == 1) {
            spawnDirection = new Vector2(1, 1);
        } else if (randomBallPosition == 2) {
            spawnDirection = new Vector2(1, -1);
        } else if (randomBallPosition == 3) {
            spawnDirection = new Vector2(-1, -1);
        } else if (randomBallPosition == 4) {
            spawnDirection = new Vector2(-1, 1);
        }

        ballRigidbody.velocity = (spawnDirection * speed); // Modify the Rigidbody based on the direction multiplied by speed

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
        
    }
}
