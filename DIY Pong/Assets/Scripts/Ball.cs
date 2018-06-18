﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour {

    float speed; // Variable for speed of the ball
    public Vector2 speedMinMax; // Min and max speed based on the difficulty %
    Rigidbody2D ballRigidbody; // Variable for the reference of the Rigidbody of the ball
    Vector2 spawnDirection; // Variable for the random spawn direction
    

    // Use this for initialization
    void Start () {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent()); // The Lerp value between min and max speed based on the difficulty.

        ballRigidbody = GetComponent<Rigidbody2D>(); // Reference to the Rigidbody of the ball
        
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

    void Update() {
        ResetBallPosition();
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Vector2 randomdisplacement = new Vector2(Random.Range(0f, 0.5f), Random.Range(0f, 0.5f));
        print(randomdisplacement);
        ballRigidbody.velocity = ballRigidbody.velocity + randomdisplacement;
    }

    void ResetBallPosition() {
        if (Input.GetKeyDown(KeyCode.R)) {
            transform.position = new Vector2(-8, 4);
        }
    }
}
