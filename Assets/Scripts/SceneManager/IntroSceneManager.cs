using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSceneManager : MonoBehaviour {

    public ScreenFader fader;

    void Start()
    {
        fader.StartScene();
    }

    void Update()
    {
        if(fader.HasSceneEnded())
        {
            SceneManager.LoadScene("FirstStageScene");
        }
    }

    public void StartGame() {
        fader.EndScene();
    }
}
