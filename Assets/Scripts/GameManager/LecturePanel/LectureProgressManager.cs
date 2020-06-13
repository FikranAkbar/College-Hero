using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LectureProgressManager : MonoBehaviour
{
    [Header("Lectures")]
    public Lectures[] lectures;

    [Header("UI Panel")]
    public GameObject LectureProgressPanel;

    [Header("UI Elements")]
    public Slider EnergyBar;
    public Text EnergyPercentage;
    public Slider pointBar;
    public Text pointText;
    public Slider levelBar;
    public Text levelText;
    public Slider LoadingBar;
    public Text LoadingText;

    [Header("Point Result")]
    [SerializeField] int point;
    [SerializeField] int currentPoint;
    [SerializeField] int level;
    [SerializeField] int currentLevel;

    [Header("Lecture Time")]
    [SerializeField] float duration;
    [SerializeField] float lectureDuration;

    [Header("Energy")]
    [SerializeField] float decreasingSpeed = 40f;
    [SerializeField] float energyDecreasing;
    [SerializeField] float currentEnergy;

    PlayerStatus playerStatus;
    LectureDisplayManager lectureDisplay;
    float timeToBack = 3f;
    int index = 0;
    
    private void Awake()
    {
        playerStatus = FindObjectOfType<PlayerStatus>();
        lectureDisplay = FindObjectOfType<LectureDisplayManager>();
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
        duration -= Time.fixedDeltaTime * decreasingSpeed;
        if (LoadingBar.value == LoadingBar.minValue)
        {
            //index = LectureDisplayManager.lectureIndex;
            currentEnergy = playerStatus.Get_Energy();
            if (index == 0)
            {
                currentPoint = playerStatus.Get_CreativityPoints();
                currentLevel = playerStatus.Get_CreativityLevel();
            }
            else if (index == 1)
            {
                currentPoint = playerStatus.Get_IntelligencePoints();
                currentLevel = playerStatus.Get_IntelligenceLevel();
            }

            if (playerStatus.Get_Health() > 70)
            {
                point = 3;
            }
            else if (playerStatus.Get_Health() > 40)
            {
                point = 1;
            }
        }

        if (duration <= 0)
        {
            LoadingBar.value += Time.fixedDeltaTime;
            duration = lectureDuration;
            LoadingText.text = (int)(LoadingBar.value * 100) + " %";
            EnergyDecreament();
            PointIncrement();
        }

        if (LoadingBar.value == LoadingBar.maxValue)
        {
            timeToBack -= Time.fixedDeltaTime;
            if (timeToBack <= 0)
            {
                timeToBack = 3f;
                LoadingBar.value = 0;
                lectureDisplay.ShowLectureInfoPanel();
                lectureDisplay.HideLectureProgressPanel();
            }

            if(index == 0)
            {
                playerStatus.Set_SpecificCreativityPoints(point);
            }
            else if(index == 1)
            {
                playerStatus.Set_SpecificIntelligencePoints(point);
            }
        }
    }

    public void PointIncrement()
    {
        pointBar.value = currentPoint + LoadingBar.value / LoadingBar.maxValue * point;
        pointText.text = currentPoint + LoadingBar.value / LoadingBar.maxValue * point + " / 50";
    }

    public void LevelIncrement()
    {

    }

    public void EnergyDecreament()
    {
        energyDecreasing = LoadingBar.value / LoadingBar.maxValue * 10 * lectureDuration;
        playerStatus.SetSpecific_Energy(currentEnergy - energyDecreasing);
        EnergyBar.value = playerStatus.Get_Energy() / 100f;
        EnergyPercentage.text = (int)playerStatus.Get_Energy() + "";
    }
}
