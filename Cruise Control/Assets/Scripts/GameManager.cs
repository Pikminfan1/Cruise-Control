﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager UI;

    // Start is called before the first frame update
    void Start()
    {
        //makes sure pause menu isn't on at the start
        UI.GetComponentInChildren<Canvas>().enabled = false;
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}

    public void TogglePauseMenu()
    {
        if (UI.GetComponentInChildren<Canvas>().enabled)
        {
            //turn pause menu off
            UI.GetComponentInChildren<Canvas>().enabled = false;
            Time.timeScale = 1.0f;
        }
        else
        {
            //turn pause menu on
            UI.GetComponentInChildren<Canvas>().enabled = true;
            Time.timeScale = 0f;
        }

        Debug.Log("GAMEMANAGER:: TimeScale: " + Time.timeScale);
    }
    
}
