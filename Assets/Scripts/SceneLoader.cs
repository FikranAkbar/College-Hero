using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    AllRoleInformation allRoleInformation;

    private void Start()
    {
        allRoleInformation = FindObjectOfType<AllRoleInformation>();
    }

    public void BackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void NextButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Maps_AreaKota");
    }
}
