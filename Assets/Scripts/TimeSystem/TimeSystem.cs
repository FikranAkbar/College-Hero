using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSystem : MonoBehaviour
{
    [Header("Time Attribute")]
    List<int> dayOfMonth;
    List<string> dayName;
    List<string> monthName;
    int days = 1;
    int day = 1;
    string daysText;
    int months= 0;
    float minutes;
    string minutesText;
    int hours;
    string hoursText;
    int year = 2018;

    [Header("Time UI")]
    [SerializeField] Text dayText;
    [SerializeField] Text clockText;
    [SerializeField] Text dateText;

    // Start is called before the first frame update
    void Start()
    {
        dayOfMonth = new List<int>()
        {
            31, 28, 31, 30, 31, 30,
            31, 31, 30, 31, 30, 31 
        };
        dayName = new List<string>()
        {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };
        monthName = new List<string>()
        {
            "January", "February", "March",
            "April", "May", "June",
            "July", "August", "September",
            "October", "November", "December"
        };
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }

    private void FixedUpdate()
    {
        minutes += Time.fixedDeltaTime;
        
        if (minutes >= 60)
        {
            minutes = 0;
            hours++;
        }

        if (hours > 24)
        {
            hours = 0;
            days++;
            day++;
            if(day > 7)
            {
                day = 1;
            }
            if (days > dayOfMonth[months])
            {
                months++;
            }
        }
    }

    public void UpdateTime()
    {
        dayText.text = dayName[day];
        
        if (hours < 10)
        {
            hoursText = "0" + hours;
        }
        else
        {
            hoursText = hours + "";
        }

        if (minutes < 10)
        {
            minutesText = "0" + (int)minutes;
        }
        else
        {
            minutesText = (int)minutes + "";
        }
        clockText.text = hoursText + " : " + minutesText;
        dateText.text = days + " " + monthName[months] + " " + "2018";
    }
}
