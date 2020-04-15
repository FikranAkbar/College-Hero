using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsTemplate
{
    public Sprite charImage;

    //Berkaitan dengan kehidupan sehari-hari
    public int energy;
    public int largeFoodNeeds;
    public int money;
    public int days;
    public int moneyGift;

    //Berkaitan dengan penyakit
    public float health;
    public float healingSpeed;
    public string typeOfDisease;
    public float percentageOfIllness;
    public float damageMultiplier;

    //Berkaitan dengan kuliah
    public int intelligenceLevel;
    public int CreativityLevel;
    public int intelligencePoints;
    public int CreativityPoints;

    public PlayerStatsTemplate(
        int energy = 100, int largeFoodNeeds = 3, int money = 0, int days = 1, int moneyGift = 0,
        float health = 100, float healingSpeed = 0, string typeOfDisease = "", float percentageOfIllness = 0, float damageMultiplier = 0,
        int intelligenceLevel = 1, int creativityLevel = 1, int intelligencePoints = 0, int creativityPoints = 0)
    {
        this.energy = energy;
        this.largeFoodNeeds = largeFoodNeeds;
        this.money = money;
        this.days = days;
        this.moneyGift = moneyGift;
        this.health = health;
        this.healingSpeed = healingSpeed;
        this.typeOfDisease = typeOfDisease;
        this.percentageOfIllness = percentageOfIllness;
        this.damageMultiplier = damageMultiplier;
        this.intelligenceLevel = intelligenceLevel;
        CreativityLevel = creativityLevel;
        this.intelligencePoints = intelligencePoints;
        CreativityPoints = creativityPoints;
    }
}
