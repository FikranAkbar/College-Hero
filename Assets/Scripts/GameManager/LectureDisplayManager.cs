using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LectureDisplayManager : MonoBehaviour
{
    [Header("List Lectures")]
    public Lectures[] lectures;
    [Header("UI Panel")]
    public GameObject lecturePanel;
    [Header("UI Element")]
    public Text lectureType;
    public Text lectureSchedule;
    public Text lectureDescription;

    int lectureIndex = 0;

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

    public void ShowLecturePanel()
    {
        lecturePanel.SetActive(true);
    }

    public void HideLecturePanel()
    {
        lecturePanel.SetActive(false);
    }
}
