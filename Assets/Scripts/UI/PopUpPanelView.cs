using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpPanelView : MonoBehaviour {

    public Text outputText;

    public Button positiveButton;

    public Button negativeButton;

	public void ShowPanel()
    {
        gameObject.SetActive(true);
    }

    public void HidePanel()
    {
        gameObject.SetActive(false);
    }

    public void CustomizeAndShowPanel(string popupText, string positiveBtnText, string negativeBtnText)
    {
        this.ChangeOutputText(popupText);
        Text positiveText = this.positiveButton.GetComponentInChildren<Text>();
        if(positiveText != null)
        {
            positiveText.text = positiveBtnText;
        }

        Text negativeText = this.negativeButton.GetComponentInChildren<Text>();
        if (negativeText != null)
        {
            negativeText.text = negativeBtnText;
        }

        this.ShowPanel();
    }

    private void ChangeOutputText(string text)
    {
        outputText.text = text;
    }

    public void OnPositiveButtonClicked()
    {
        this.OnPanelButtonClicked();
    }

    public void OnNegativeButtonClicked()
    {
        this.OnPanelButtonClicked();
    }

    private void OnPanelButtonClicked()
    {
        this.HidePanel();
    }
}
