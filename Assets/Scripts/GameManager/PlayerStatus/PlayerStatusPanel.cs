using System.Collections;
using System.Collections.Generic;
using UnityEditor.Sprites;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerStatusPanel : MonoBehaviour
{
    #region Panel
    [Header("Panel")]
    [SerializeField] GameObject playerStatusPanel;
    [SerializeField] bool playerStatusIsDisplayed = false;
    [SerializeField] EventSystem eventSystem;
    #endregion

    #region PanelComponents
    [Header("Components")]
    
    [Header("Header Information")]
    [SerializeField] Image ImageHolder;
    [SerializeField] Text nameText;
    [SerializeField] Slider energyBar;
    [SerializeField] Text energyText;

    [Header("Intelligence")]
    [SerializeField] Slider intBar;
    [SerializeField] Text intPercentage;
    [SerializeField] Text intLevelText;

    [Header("Creativity")]
    [SerializeField] Slider creBar;
    [SerializeField] Text crePercentage;
    [SerializeField] Text creLevelText;

    [Header("Health")]
    [SerializeField] Slider health;
    [SerializeField] Text healthText;
    [SerializeField] Text diseaseText;
    [SerializeField] Slider illnessBar;
    [SerializeField] Text percentageOfIllnessText;
    [SerializeField] Slider bigEatingObligations;
    [SerializeField] Text bigEatingText;
    #endregion

    PlayerStatus playerStat;

    private void Start()
    {
        DontDestroyOnLoad(eventSystem);
        eventSystem = FindObjectOfType<EventSystem>();
        playerStat = FindObjectOfType<PlayerStatus>();
    }

    private void Update()
    {
        if (playerStatusIsDisplayed)
        {
            UpdatePlayerStatus(
                playerStat.role.GetRoleStatus().charImage,
                playerStat.Get_PlayerName(),
                playerStat.Get_Energy(),
                playerStat.Get_IntelligencePoints(),
                playerStat.Get_IntelligenceLevel(),
                playerStat.Get_CreativityPoints(),
                playerStat.Get_CreativityLevel(),
                playerStat.Get_Health(),
                playerStat.Get_TypeOfDisease(),
                playerStat.Get_PercentageOfIllness(),
                playerStat.Get_LargeFoodNeeds());
        }
    }

    public void ShowPlayerStatusPanel()
    {
        playerStatusPanel.SetActive(true);
        playerStatusIsDisplayed = true;
    }

    public void HidePlayerStatusPanel()
    {
        playerStatusPanel.SetActive(false);
        playerStatusIsDisplayed = false;
    }

    public void UpdatePlayerStatus(
        Sprite image,
        string name,
        int energy,
        int intPoint,
        int intLevel,
        int crePoint,
        int creLevel,
        int healthPoint,
        string disease,
        int percentageOfIllness,
        int dailyMeal
        )
    {
        // Adjust Header Information
        ImageHolder.sprite = image;
        nameText.text = name;
        energyBar.value = energy;
        energyText.text = energy + " %";

        // Adjust Intelligence Information
        intBar.value = intPoint;
        intPercentage.text = intPoint / 50 * 100 + " %";
        intLevelText.text = intLevel + "";

        // Adjust Creativity Information
        creBar.value = crePoint;
        crePercentage.text = crePoint / 50 * 100 + " %";
        creLevelText.text = creLevel + "";

        // Adjust Health Information
        health.value = healthPoint;
        healthText.text = healthPoint + "";
        diseaseText.text = disease;
        illnessBar.value = percentageOfIllness;
        percentageOfIllnessText.text = percentageOfIllness + " %";
        bigEatingObligations.value = dailyMeal;
        bigEatingText.text = dailyMeal + " / 3";
    }
}
