﻿using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    #region Status Variable

    [SerializeField] string playerName;

    [Header("Daily Status")]
    [SerializeField] int energy;
    [SerializeField] int largeFoodNeeds;
    [SerializeField] int days;
    [SerializeField] int money;

    [Header("Health Status")]
    [SerializeField] int health;
    [SerializeField] float healingSpeed;
    [SerializeField] string typeOfDisease;
    [SerializeField] int percentageOfIllness;
    [SerializeField] float damageMultiplier;

    [Header("Lecture Status")]
    [SerializeField] int intelligenceLevel;
    [SerializeField] int intelligencePoints;
    [SerializeField] int creativityLevel;
    [SerializeField] int creativityPoints;
    #endregion

    #region HUD Display
    [Header("HUD Display")]
    [SerializeField] Text greetingText;
    [SerializeField] Text moneyText;
    [SerializeField] Slider healthBarSlider;
    [SerializeField] Slider energyBarSlider;
    [SerializeField] Text multiplierEffectText;
    #endregion

    #region Panels
    [Header("Panels")]
    [SerializeField] GameObject playerStatusPanel;
    [SerializeField] bool playerStatusIsDisplayed = false;
    [SerializeField] EventSystem eventSystem;
    #endregion

    CharacterRole role;

    private void Awake()
    {
        role = FindObjectOfType<CharacterRole>();
        AssignNewPlayerStatus();
        DontDestroyOnLoad(eventSystem);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayStatusOnHUD();
        if (playerStatusIsDisplayed)
        {
            // write something to display in UI;
        }
    }

    public void AssignNewPlayerStatus()
    {
        playerName = role.AssignName();

        #region Assign Daily Status
        energy = 100;
        largeFoodNeeds = 0;
        days = 1;
        money = role.GetRoleStatus().moneyGift;
        #endregion

        #region Assign Health Status
        health = 100;
        healingSpeed = role.GetRoleStatus().healthInc;
        typeOfDisease = "-";
        percentageOfIllness = 0;
        damageMultiplier = role.GetRoleStatus().multiplierFactor;
        #endregion

        #region Assign Lecture Status
        intelligenceLevel = 1;
        intelligencePoints = 0;
        creativityLevel = 1;
        creativityPoints = 0;
        #endregion
    }

    public void DisplayStatusOnHUD()
    {
        greetingText.text = "Hello, " + playerName;
        moneyText.text = money.ToString();
        healthBarSlider.value = health / 100f;
        energyBarSlider.value = energy / 100f;
        multiplierEffectText.text = damageMultiplier.ToString();
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
}
