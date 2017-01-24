using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSceneManager : MonoBehaviour {

	public float splashTime = 4.0f;

    public ScreenFader fader;

	void Start() {
        fader.StartScene();

		Invoke ("SwitchToIntroScene", splashTime);
	}

    void Update()
    {
        if(fader.HasSceneEnded())
        {
            SceneManager.LoadScene("IntroScene");
        }
    }

	void SwitchToIntroScene() {
        fader.EndScene();
	}
}
