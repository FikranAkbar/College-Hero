using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    #region Status Variable
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
    [SerializeField] Text moneyText;
    [SerializeField] Text healthBarText;
    [SerializeField] Text energyBarText;
    [SerializeField] Text multiplierEffectText;
    #endregion

    CharacterRole role;

    private void Awake()
    {
        role = FindObjectOfType<CharacterRole>();
        AssignNewPlayerStatus();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayStatusOnHUD();
    }

    public void AssignNewPlayerStatus()
    {
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
        moneyText.text = money.ToString();
        healthBarText.text = health.ToString();
        energyBarText.text = energy.ToString();
        multiplierEffectText.text = damageMultiplier.ToString();
    }
}
