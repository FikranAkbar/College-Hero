using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{

    public GameObject MainMenuCanvas;
    public GameObject ChooseRoleCanvas;
    public int selectedRole;

    private void Start()
    {
        MainMenuCanvas.SetActive(true);
        ChooseRoleCanvas.SetActive(false);
    }

    public void GoToChooseRole()
    {
        MainMenuCanvas.SetActive(false);
        ChooseRoleCanvas.SetActive(true);
    }

    public void BackToMenu()
    {
        MainMenuCanvas.SetActive(true);
        ChooseRoleCanvas.SetActive(false);
    }

    public void ContinueGame()
    {
        Debug.LogWarning("Masih dalam progress pengembangan");
    }

    public void StartGame()
    {

    }

    public void ChooseAnakDesa()
    {
        selectedRole = 1;
    }

    public void ChooseAnakKota()
    {
        selectedRole = 2;
    }

    public void ChooseAnakSultan()
    {
        selectedRole = 3;
    }
    
    public void GenerateCharacterFromNewGame()
    {
        GameObject.Find("Player").GetComponent<PlayerStats>().GenerateCharacter(selectedRole);
    }
}
