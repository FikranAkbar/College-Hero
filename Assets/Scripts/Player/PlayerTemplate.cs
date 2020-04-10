using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTemplate
{
    // Berkaitan dengan kebutuhan sehari-hari
    private int energy;
    private int largeFoodNeeds;
    private int money;

    // Berkaitan dengan penyakit
    private int health;
    private int healingSpeed;
    private string typeOfDisease;
    private float percentageOfIllness;
    private float damageMultiplier;

    // Berkaitan dengan perkuliahan
    private int intelligenceLevel;
    private int creativityLevel;
    private int creativityPoints;
    private int intelligencePoints;

    public PlayerTemplate(
        int energy, int largeFoodNeeds, int money, 
        int health, int healingSpeed, string typeOfDisease, float percentageOfIllness, float damageMultiplier, 
        int intelligenceLevel, int creativityLevel, int creativityPoints, int intelligencePoints)
    {
        this.energy = energy;
        this.largeFoodNeeds = largeFoodNeeds;
        this.money = money;
        this.health = health;
        this.healingSpeed = healingSpeed;
        this.typeOfDisease = typeOfDisease;
        this.percentageOfIllness = percentageOfIllness;
        this.damageMultiplier = damageMultiplier;
        this.intelligenceLevel = intelligenceLevel;
        this.creativityLevel = creativityLevel;
        this.creativityPoints = creativityPoints;
        this.intelligencePoints = intelligencePoints;
    }

    public int Energy { get => energy; set => energy = value; }
    public int LargeFoodNeeds { get => largeFoodNeeds; set => largeFoodNeeds = value; }
    public int Money { get => money; set => money = value; }
    public int Health { get => health; set => health = value; }
    public int HealingSpeed { get => healingSpeed; set => healingSpeed = value; }
    public string TypeOfDisease { get => typeOfDisease; set => typeOfDisease = value; }
    public float PercentageOfIllness { get => percentageOfIllness; set => percentageOfIllness = value; }
    public float DamageMultiplier { get => damageMultiplier; set => damageMultiplier = value; }
    public int IntelligenceLevel { get => intelligenceLevel; set => intelligenceLevel = value; }
    public int CreativityLevel { get => creativityLevel; set => creativityLevel = value; }
    public int CreativityPoints { get => creativityPoints; set => creativityPoints = value; }
    public int IntelligencePoints { get => intelligencePoints; set => intelligencePoints = value; }
}
