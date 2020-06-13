using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LectureDisplayManager : MonoBehaviour
{
    [Header("List Lectures")]
    public Lectures[] lectures;
    [Header("UI Panel")]
    public GameObject LectureUI;
    public GameObject LectureInfoPanel;
    public GameObject LectureProgressPanel;
    [Header("UI Element")]
    public Text lectureType;
    public Text lectureSchedule;
    public Text lectureDescription;

    public static int lectureIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowInfo();
    }

    public void ShowInfo()
    {
        lectureType.text = lectures[lectureIndex].lectureType;
        lectureSchedule.text = lectures[lectureIndex].lectureSchedule;
        lectureDescription.text = lectures[lectureIndex].lectureDescription;
    }
    public void ShowLectureUI()
    {
        LectureUI.SetActive(true);
    }

    public void HideLectureUI()
    {
        LectureUI.SetActive(false);
    }

    public void ShowLectureInfoPanel()
    {
        LectureInfoPanel.SetActive(true);
    }

    public void HideLectureInfoPanel()
    {
        LectureInfoPanel.SetActive(false);
    }

    public void ShowLectureProgressPanel()
    {
        LectureProgressPanel.SetActive(true);
    }

    public void HideLectureProgressPanel()
    {
        LectureProgressPanel.SetActive(false);
    }
}
