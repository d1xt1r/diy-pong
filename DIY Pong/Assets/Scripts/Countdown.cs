using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public Text countdownText;
    //string[] count = { "3", "2", "1", "GO!" }; 

    // Use this for initialization
    void Start () {
        StartCoroutine("CountdownTimer");
    }
	
    IEnumerator CountdownTimer() {
        Time.timeScale = 0; // Freeze the game
        float freezeTime = 4f; //
        while (Time.realtimeSinceStartup < freezeTime) {
            yield return null;
        }
            Time.timeScale = 1; // Unfreeze the game
    }
}
