﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceManager : MonoBehaviour {

    public uint numChoices;

    public DoorView[] doors;

    public PopUpPanelView popup;

    public PopUpPanelView consequencesPopup;

    public ScreenFader fader;

    private DoorView door;

    private bool shouldLoadScene;

    private int sceneNumber;

    void Start () {
        this.ResetNumChoices();

        this.popup.positiveButton.onClick.AddListener(OnChoiceSelected);
        this.popup.negativeButton.onClick.AddListener(RemoveDoorSelection);
        this.consequencesPopup.positiveButton.onClick.AddListener(OnChoiceChoosed);
	}

    void Update()
    {
        if(this.shouldLoadScene && this.fader.HasSceneEnded())
        {
            SceneManager.LoadScene(this.sceneNumber);
        }
    }

    private void OnChoiceChoosed()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;

        if(SceneManager.GetSceneByBuildIndex(currentIndex + 1) != null)
        {
            this.shouldLoadScene = true;
            this.sceneNumber = currentIndex + 1;
            this.fader.EndScene();
        }
    }

    private void RemoveDoorSelection()
    {
        this.door = null;
    }

    private void OnChoiceSelected()
    {
        string consequence = door.GetChoiceConsequences();

        this.ShowConsequence(consequence);
    }

    private void ResetNumChoices()
    {
        int i = 0;

        for (i = 0; i < numChoices; i++)
        {
            doors[i].gameObject.SetActive(true);
        }

        for(int j = i; j < doors.Length; j++)
        {
            doors[j].gameObject.SetActive(false);
        }
    }

    public void OnDoorClicked(DoorView door)
    {
        this.door = door;

        this.ShowChoice(door);
    }

    private void ShowChoice(DoorView door)
    {
        string choice = door.GetChoice();

        this.ShowChoice(choice);
    }

    private void ShowChoice(string choice)
    {
        popup.CustomizeAndShowPanel(choice, "Sure, Take me through this.", "I'll choose another door.");
    }

    private void ShowConsequence(string consequence)
    {
        consequencesPopup.CustomizeAndShowPanel(consequence, "Sure, let's do this.", "Rewind my choice.");
    }
}
