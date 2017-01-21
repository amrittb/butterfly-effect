using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSceneManager : MonoBehaviour {

	public float splashTime = 4.0f;

	void Start() {
		Invoke ("SwitchToIntroScene", splashTime);
	}

	void SwitchToIntroScene() {
		SceneManager.LoadScene ("IntroScene");
	}
}
