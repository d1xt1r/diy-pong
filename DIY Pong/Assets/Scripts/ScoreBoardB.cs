using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardB : MonoBehaviour {

    public int scoreB = 0;
    public Text textFieldB;

	// Use this for initialization
	void Start () {
        textFieldB.text = "" + scoreB.ToString();
	}

    void OnCollisionEnter2D(Collision2D collision) {
        print("Collided");
        if (collision.gameObject.name == "Ball") {
            scoreB = scoreB + 1;
            textFieldB.text = "" + scoreB.ToString();
        }
    }
}
