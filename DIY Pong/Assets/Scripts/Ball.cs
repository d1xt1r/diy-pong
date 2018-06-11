using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 10;
    Rigidbody2D ballRigidbody;
    Vector2 spawnDirection;

    // Use this for initialization
    void Start () {
        ballRigidbody = GetComponent<Rigidbody2D>();
        //ballRigidbody.AddForce(new Vector2(5 * force, force));

        int randomBallPosition = Random.Range(1, 5);

        if (randomBallPosition == 1) {
            spawnDirection = new Vector2(1, 1);
        } else if (randomBallPosition == 2) {
            spawnDirection = new Vector2(1, -1);
        } else if (randomBallPosition == 3) {
            spawnDirection = new Vector2(-1, -1);
        } else if (randomBallPosition == 4) {
            spawnDirection = new Vector2(-1, 1);
        }

        ballRigidbody.velocity = (spawnDirection * speed);

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
        
    }
}
