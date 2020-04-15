using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsTemplate
{
    public RoleCharacter AnakDesa;
    public RoleCharacter AnakKota;
    public RoleCharacter AnakSultan;

    //Berkaitan dengan kehidupan sehari-hari
    public int energy;
    public int largeFoodNeeds;
    public int money;
    public int days;

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
        int energy = 100, int largeFoodNeeds = 3, int money = 0, int days = 1,
        float health = 100, float healingSpeed = 0, string typeOfDisease = "", float percentageOfIllness = 0, float damageMultiplier = 0,
        int intelligenceLevel = 1, int creativityLevel = 1, int intelligencePoints = 0, int creativityPoints = 0)
    {
        this.energy = energy;
        this.largeFoodNeeds = largeFoodNeeds;
        this.money = money;
        this.days = days;
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

    public void CreateAnakDesa()
    {
        this.money = AnakDesa.money;
        this.healingSpeed = AnakDesa.healthInc;
        this.damageMultiplier = AnakDesa.multiplierFactor;
    }

    public void CreateAnakKota()
    {
        this.money = AnakKota.money;
        this.healingSpeed = AnakKota.healthInc;
        this.damageMultiplier = AnakKota.multiplierFactor;
    }
    public void CreateAnakSultan()
    {
        this.money = AnakSultan.money;
        this.healingSpeed = AnakSultan.healthInc;
        this.damageMultiplier = AnakSultan.multiplierFactor;
    }
}
