using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    List<string> months = new List<string>(){ "September", "Oktober", "November", "Desember", "Januari" };
    List<string> days = new List<string>() { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" };
    int n_day = 1;

    // time value
    int hours = 5;
    int minutes;
    int seconds;

    // time to display
    string display_h;
    string display_m;
    string display_s;
    string display_clock;

    [SerializeField] Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Time_Clock();
        Display_Time();
    }

    private void Display_Time()
    {
        // MINUTES
        if (minutes < 10)
        {
            display_m = "0" + minutes;
        }
        else display_m = minutes.ToString();

        // HOURS
        if (hours < 10)
        {
            display_h = "0" + hours;
        }
        else display_h = hours.ToString();

        if(seconds > 30) display_clock = display_h + " : " + display_m;
        else display_clock = display_h + "   " + display_m;

        timeText.text = display_clock;
    }

    private void Time_Clock()
    {
        seconds += 1;
        if (seconds >= 60)
        {
            minutes += 1;
            seconds = 0;
            if (minutes >= 60)
            {
                hours += 1;
                minutes = 0;
                if (hours >= 24)
                {
                    hours = 5;
                    // AUTO SLEEP -- BACK TO HOME
                    // RESET DAYS -- to 5 am
                }
            }
        }
    }
}
