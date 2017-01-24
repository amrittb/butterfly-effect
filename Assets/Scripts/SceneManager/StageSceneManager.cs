using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSceneManager : MonoBehaviour {

    public ScreenFader fader;

    public NarratorEngine narrator;

	void Start () {
        this.fader.StartScene();
        this.ShowSceneNarration();	
	}

    private void ShowSceneNarration()
    {
        narrator.ShowNarration();
    }
}
