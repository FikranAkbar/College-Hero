using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class JobProgressManager : MonoBehaviour
{
    [Header("Jobs")]
    public Jobs[] job;

    [Header("UI Panel")]
    public GameObject JobProgressPanel;

    [Header("UI Elements")]
    public Slider EnergyBar;
    public Text EnergyPercentage;
    public Text MoneyText;
    public Slider LoadingBar;
    public Text LoadingText;

    [SerializeField] int index;
    [SerializeField] float workingDuration;
    [SerializeField] float duration;
    
    [SerializeField] int money;
    [SerializeField] int currentMoney;

    [SerializeField] float decreasingSpeed = 10;

    [SerializeField] float energyDecreasing;
    [SerializeField] float currentEnergy;
    

    PlayerStatus playerStatus;

    // Start is called before the first frame update
    void Start()
    {
        index = JobDisplayManager.jobIndex;
        workingDuration = JobDisplayManager.duration;
        playerStatus = FindObjectOfType<PlayerStatus>();
        currentEnergy = playerStatus.Get_Energy();
        currentMoney = playerStatus.Get_Money();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            LoadingBar.value = 0;
        }
        LoadingBarProgress();
    }

    public void LoadingBarProgress()
    {
        duration -= Time.fixedDeltaTime * decreasingSpeed * (1/workingDuration);
        if(duration <= 0)
        {
            LoadingBar.value += Time.fixedDeltaTime;
            duration = workingDuration;
            LoadingText.text = (int)(LoadingBar.value * 100) + " %";
            MoneyIncrement();
            EnergyDecreament();
        }
    }

    public void MoneyIncrement()
    {
        int moneyGet = job[index].salary;
        money = (int)(LoadingBar.value/LoadingBar.maxValue * moneyGet * workingDuration);
        playerStatus.SetSpecific_Money(currentMoney + money);
        MoneyText.text = playerStatus.Get_Money() + "";
    }

    public void EnergyDecreament()
    {
        energyDecreasing = LoadingBar.value / LoadingBar.maxValue * 10 * workingDuration;
        playerStatus.SetSpecific_Energy(currentEnergy - energyDecreasing);
        EnergyBar.value = playerStatus.Get_Energy() / 100f;
        EnergyPercentage.text = playerStatus.Get_Energy() + "";
    }
}
