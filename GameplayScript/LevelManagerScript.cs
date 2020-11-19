using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
using UnityEngine.UI;

public class LevelManagerScript : MonoBehaviour {

    public float fadeSpeed = 1.5f;
    public bool sceneStarting = true;
    public bool exitgame = false;
    public RawImage rawImage;

    public void EnterGame() {

        SceneManager.LoadScene("Scene01_KingPass");

    }
    public void ReturnMainMenu() {

        SceneManager.LoadScene("StartMenuScene");

    }

    public void ExitGame() {

        Application.Quit();

    }

    void Awake() {
       // rawImageGameObject.SetActive(true);
       
    }
 
    void Update() {
        if (sceneStarting)
            StartScene();
    }
 
    private void FadeToClear() {
        rawImage.color = Color.Lerp(rawImage.color, Color.clear, fadeSpeed * Time.deltaTime);
    }
 
    private void FadeToBlack() {
        rawImage.color = Color.Lerp(rawImage.color, Color.black, fadeSpeed * Time.deltaTime);
        
        if (rawImage.color.a > 0.95f) {
            CancelInvoke("FadeToBlack");
            if ( Application.loadedLevelName == "StartMenuScene")
                EnterGame();
            else
                ReturnMainMenu();
        }

    }
 
    public void StartScene() {
        FadeToClear();
        if (rawImage.color.a < 0.05f) {
            rawImage.color = Color.clear;
            rawImage.enabled = false;
            sceneStarting = false;
        }
    }
 
    public void EndScene() {
        rawImage.enabled = true;
        InvokeRepeating("FadeToBlack", 1f, 0.05f) ;

    }
 
    void OnDestroy() {
 
    }

}
