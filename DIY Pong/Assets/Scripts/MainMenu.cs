using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

    public AudioSource source;
    public AudioClip hover;
    public AudioClip click;

    public void Wrapper() {
        StartCoroutine(PlayGame());
    }

    public void OnHover() {
        source.PlayOneShot(hover);
    }

    public void OnClick() {
        source.PlayOneShot(click);
    }

    IEnumerator PlayGame() {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
        
    }

    public void QuitGame() {
        Application.Quit();
    }

}
