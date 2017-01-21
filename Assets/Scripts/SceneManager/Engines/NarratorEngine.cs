using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NarratorEngine : MonoBehaviour
{

    public Text narrationText;

    public string[] narrations;

    private int index = 0;

    public void SwitchToNext()
    {
        index += (index != narrations.Length) ? 1 : 0;
        this.ShowNarration();
    }

    public void ShowNarration()
    {
        if(narrations != null && narrations.Length > 0 && narrations.Length != index)
        {
            narrationText.text = narrations[index];
        }
    }
}
