using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleController : MonoBehaviour {

    public float speed = 10;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        float inputY = Input.GetAxisRaw("Vertical_Left"); // Input for vertical movement
        float velocity = inputY * speed; // Velocity is the speed of something in a given direction
        transform.Translate(Vector2.up * velocity * Time.deltaTime); // Moving the paddle in the direction and distance of translation. Vector2.up is shorthand for writing Vector2(0, 1) or moving vertically
    }
}
