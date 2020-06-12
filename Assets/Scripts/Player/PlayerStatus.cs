using JetBrains.Annotations;
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
    [SerializeField] float energy;
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


    public CharacterRole role;

    private void Awake()
    {
        DontDestroyOnLoad(FindObjectOfType<EventSystem>());
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

    #region GetterSetter Variabel
    public string Get_PlayerName()
    {
        return playerName;
    }
    // Daily Status
    public float Get_Energy()
    {
        return energy;
    }
    public void Set_Energy(float value)
    {
        energy = energy + value;
    }
    public void SetSpecific_Energy(float value)
    {
        energy = value;
    }
    public int Get_LargeFoodNeeds()
    {
        return largeFoodNeeds;
    }
    public void Set_LargeFoodNeeds(int value)
    {
        largeFoodNeeds = largeFoodNeeds + value;
    }
    public int Get_Money()
    {
        return money;
    }
    public void Set_Money(int value)
    {
        money = money + value;
    }
    public void SetSpecific_Money(int value)
    {
        money = value;
    }

    // Health Status
    public int Get_Health()
    {
        return health;
    }
    public void Set_Health(int value)
    {
        health = health + value;
    }
    public string Get_TypeOfDisease()
    {
        return typeOfDisease;
    }
    public void Set_TypeOfDisease(int value)
    {
        typeOfDisease = typeOfDisease + value;
    }
    public int Get_PercentageOfIllness()
    {
        return percentageOfIllness;
    }
    public void Set_PercentageOfIllness(int value)
    {
        percentageOfIllness = percentageOfIllness + value;
    }
    public float Get_DamageMultiplier()
    {
        return damageMultiplier;
    }
    public void Set_DamageMultiplier(float value)
    {
        damageMultiplier = value;
    }

    // Lecture Status
    public int Get_IntelligencePoints()
    {
        return intelligencePoints;
    }
    public void Set_IntelligencePoints(int value)
    {
        intelligencePoints = intelligencePoints + value;
    }
    public int Get_IntelligenceLevel()
    {
        return intelligenceLevel;
    }
    public void Set_IntelligenceLevel(int value)
    {
        intelligenceLevel = value;
    }
    public int Get_CreativityPoints()
    {
        return creativityPoints;
    }
    public void Set_CreativityPoints(int value)
    {
        creativityPoints = creativityPoints + value;
    }
    public int Get_CreativityLevel()
    {
        return creativityLevel;
    }
    public void Set_CreativityLevel(int value)
    {
        creativityLevel = creativityLevel + value;
    }
    #endregion
}
