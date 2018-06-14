using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;
using UnityEngine.SceneManagement;

public class PressSpace : MonoBehaviour {

    //public TextMeshProUGUI pressSpaceText;

    // Use this for initialization
    void Start () {
            //pressSpaceText = GetComponent<TextMeshProUGUI>();
            //Time.timeScale = 0;
     }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene(2);
            //Destroy(pressSpaceText);
            //Time.timeScale = 1;
        }

    }
}
