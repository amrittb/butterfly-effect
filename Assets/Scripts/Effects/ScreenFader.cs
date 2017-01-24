using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ScreenFader : MonoBehaviour {
    public float fadeSpeed = 1.5f;


    private bool sceneStarting;
    private bool sceneEnding;

    private bool sceneStarted;
    private bool sceneEnded;

    private Image panelImage;


    void Awake() {
        panelImage = GetComponent<Image>();
    }

    void Update() {
        if (sceneStarting)
            StartScene();

        if (sceneEnding) {
            EndScene();
        }
    }


    void FadeToClear() {
        panelImage.color = Color.Lerp(panelImage.color, Color.clear, fadeSpeed * Time.deltaTime);
    }


    void FadeToWhite() {
        panelImage.color = Color.Lerp(panelImage.color, Color.white, fadeSpeed * Time.deltaTime);
    }

    public void StartScene() {
        if (!sceneStarting) {
            sceneStarting = true;
        }

        panelImage.enabled = true;

        FadeToClear();

        if (panelImage.color.a <= 0.05f) {
            panelImage.color = Color.clear;
            panelImage.enabled = false;

            sceneStarting = false;
            sceneStarted = true;
        }
    }

    public void Reset() {
        sceneEnding = true;
    }

    public void EndScene() {
        if (!sceneEnding) {
            sceneEnding = true;
        }

        panelImage.enabled = true;

        FadeToWhite();

        if (panelImage.color.a >= 0.95f) {
            panelImage.color = Color.white;

            sceneEnding = false;
            sceneEnded = true;
        }
    }

    public bool HasSceneStarted() {
        return sceneStarted;
    }

    public bool HasSceneEnded() {
        return sceneEnded;
    }
}