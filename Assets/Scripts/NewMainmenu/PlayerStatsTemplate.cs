using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsTemplate
{
    // Berkaitan dengan kehidupan sehari-hari
    public int energy;
    public int largefoodNeeds;
    public int money;
    public int days;

    //Berkaitan dengan penyakit
    public int health;
    public int healingSpeed;
    public string typeOfDisease;
    public float percentageOfIllness;
    public float damageMultiplier;

    //Berkaitan dengan kuliah
    public int intelligenceLevel;
    public int creativityLevel;
    public int intelligencePoints;
    public int creativityPoints;

    public PlayerStatsTemplate(int energy = 100, int largefoodNeeds = 0, int money = 100, int days = 1, 
        int health = 100, int healingSpeed = 100, string typeOfDisease = "-", float percentageOfIllness = 0f, float damageMultiplier = 100f, 
        int intelligenceLevel = 1, int creativityLevel = 1, int intelligencePoints = 0, int creativityPoints = 0)
    {
        this.energy = energy;
        this.largefoodNeeds = largefoodNeeds;
        this.money = money;
        this.days = days;
        this.health = health;
        this.healingSpeed = healingSpeed;
        this.typeOfDisease = typeOfDisease;
        this.percentageOfIllness = percentageOfIllness;
        this.damageMultiplier = damageMultiplier;
        this.intelligenceLevel = intelligenceLevel;
        this.creativityLevel = creativityLevel;
        this.intelligencePoints = intelligencePoints;
        this.creativityPoints = creativityPoints;
    }
}
