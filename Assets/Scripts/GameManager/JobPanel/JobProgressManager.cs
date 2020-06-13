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

    [Header("Salary")]
    [SerializeField] int money;
    [SerializeField] int currentMoney;
    
    [Header("Working Time")]
    [SerializeField] int index;
    [SerializeField] float workingDuration;
    [SerializeField] float duration;
    
    [Header("Energy")]
    [SerializeField] float decreasingSpeed = 40f;
    [SerializeField] float energyDecreasing;
    [SerializeField] float currentEnergy;
    
    PlayerStatus playerStatus;
    JobDisplayManager jobDisplay;
    float timeToBack = 3f;

    private void Awake()
    {
        playerStatus = FindObjectOfType<PlayerStatus>();
        jobDisplay = FindObjectOfType<JobDisplayManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LoadingBarProgress();
    }

    public void LoadingBarProgress()
    {
        duration -= Time.fixedDeltaTime * decreasingSpeed * (1/workingDuration);
        if(LoadingBar.value == LoadingBar.minValue)
        {
            currentEnergy = playerStatus.Get_Energy();
            currentMoney = playerStatus.Get_Money();
            index = JobDisplayManager.jobIndex;
            workingDuration = JobDisplayManager.duration;
        }

        if(duration <= 0)
        {
            LoadingBar.value += Time.fixedDeltaTime;
            duration = workingDuration;
            LoadingText.text = (int)(LoadingBar.value * 100) + " %";
            MoneyIncrement();
            EnergyDecreament();
        }
        
        if(LoadingBar.value == LoadingBar.maxValue)
        {
            timeToBack -= Time.fixedDeltaTime;
            if (timeToBack <= 0)
            {
                timeToBack = 3f;
                LoadingBar.value = 0;
                jobDisplay.ShowJobPanel();
                jobDisplay.HideJobProgressPanel();
            }
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
        EnergyPercentage.text = (int)playerStatus.Get_Energy() + "";
    }
}
