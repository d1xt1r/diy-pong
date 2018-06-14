using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoardA : MonoBehaviour {

    public int scoreA = 0;
    public Text textFieldA;

	// Use this for initialization
	void Start () {
        textFieldA.text = "" + scoreA.ToString();
    }

    void Update() {
        PlayerTwoWins();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        //print("Collided");
        if (collision.gameObject.name == "Ball") {
            scoreA = scoreA + 1;
            textFieldA.text = "" + scoreA.ToString();
        }
    }

    void PlayerTwoWins() {
        if (scoreA >= 20) {
            SceneManager.LoadScene(4);
        }
    }

}
