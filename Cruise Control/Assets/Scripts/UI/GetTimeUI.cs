using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTimeUI : MonoBehaviour
{


    public TimeSpan time;
   

    void Update()
    {
        if (!GameManager.isThisGameOver&& Time.timeScale == 1.0f)
        {
            time = DateTime.Now - GameManager.startTime;
            GetComponent<UnityEngine.UI.Text>().text = formatTime();
        }
    }
    string formatTime()
    {
        int minutes = time.Minutes;
        int seconds = time.Seconds;
        int milliseconds = time.Milliseconds;
        return string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
    
}

