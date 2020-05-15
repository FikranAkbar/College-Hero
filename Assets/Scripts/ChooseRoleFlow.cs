using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseRoleFlow : MonoBehaviour
{
    [SerializeField] GameObject inputNamePanel;
    [SerializeField] GameObject confirmationPanel;

    public void ShowInputName()
    {
        inputNamePanel.SetActive(true);
    }

    public void HideInputName()
    {
        inputNamePanel.SetActive(false);
    }

    public void ShowConfirmation()
    {
        confirmationPanel.SetActive(true);
    }

    public void HideConfirmation()
    {
        confirmationPanel.SetActive(false);
    }
}
