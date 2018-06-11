using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float force = 50;
    private Rigidbody2D ballRigidbody;

	// Use this for initialization
	void Start () {
        ballRigidbody = GetComponent<Rigidbody2D>();
        ballRigidbody.AddForce(new Vector2(5 * force, force));
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
	}
}
