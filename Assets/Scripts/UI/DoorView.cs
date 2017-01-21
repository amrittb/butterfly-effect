using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorView : MonoBehaviour
{
    public string doorChoice;

    public string doorConsquence;

    public string GetChoiceConsequences()
    {
        return doorConsquence;
    }

    internal string GetChoice()
    {
        return doorChoice;
    }
}
