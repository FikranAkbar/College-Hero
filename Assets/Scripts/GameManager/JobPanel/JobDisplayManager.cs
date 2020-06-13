using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JobDisplayManager : MonoBehaviour
{
    
    [Header("List Job")]
    public Jobs[] jobs;
    [Header("UI Panel")]
    public GameObject JobUI;
    public GameObject JobPanel;
    public GameObject JobProgressPanel;
    [Header("UI Element")]
    public Text jobName;
    public Text clothesReq;
    public Text creativityReq;
    public Text intelligenceReq;
    public Text jobDescription;
    [Header("Job Duration")]
    public Text jobDuration;
    
    public static int jobIndex = 0;
    // in hours
    public static int duration = 1;

    PlayerStatus playerStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowJobInfo();
        jobDuration.text = duration + " hours";
    }

    private void ShowJobInfo()
    {
        jobName.text = jobs[jobIndex].jobName;
        clothesReq.text = jobs[jobIndex].clothReq;
        creativityReq.text = jobs[jobIndex].creativReq + "";
        intelligenceReq.text = jobs[jobIndex].IntelReq + "";
        jobDescription.text = jobs[jobIndex].jobDescription;
    }

    public void Job_NavigateRight()
    {
        jobIndex++;
        if(jobIndex > jobs.Length - 1)
        {
            jobIndex = 0;
        }
    }

    public void Job_NavigateLeft()
    {
        jobIndex--;
        if(jobIndex < 0)
        {
            jobIndex = jobs.Length-1;
        }
    }

    public void Duration_Minus()
    {
        duration--;
        if (duration == 0)
        {
            duration = 1;
        }
    }

    public void Duration_Plus()
    {
        duration++;
        if (duration == 6)
        {
            duration = 5;
        }
    }

    public void ShowJobUI()
    {
        JobUI.SetActive(true);
    }

    public void HideJobUI()
    {
        JobUI.SetActive(false);
    }

    public void ShowJobPanel()
    {
        JobPanel.SetActive(true);
    }

    public void HideJobPanel()
    {
        JobPanel.SetActive(false);
    }

    public void ShowJobProgressPanel()
    {
        JobProgressPanel.SetActive(true);
    }

    public void HideJobProgressPanel()
    {
        JobProgressPanel.SetActive(false);
    }

}
