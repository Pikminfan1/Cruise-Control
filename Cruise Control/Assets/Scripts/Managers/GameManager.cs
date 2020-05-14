using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoSingleton<GameManager>
{
    private static float _maxStress;
    public UIManager UI;
    public GameObject gameOverCanvas;
    public GameObject player;
    public static float stress;
    public static int score;
    public static float time;
    public static DateTime startTime;
    public static float stressGrowthRate = 0.00f;
    public static float stressDecayRate = 0.05f;
    public float maxStressGrowthRate = 1.0f;
    public static bool stressAtMax = false;
    public static float maxStress;
    public float highestSpeed;
    public static int minigamesCompleted;
    public int stressMaxTime = 10;
    public float stressTime;
    private float avgTimer;
    private int avgInt = 10;
    public float avgSpeed;
    private int count;
    public static bool isThisGameOver = false;


   

    // Start is called before the first frame update
    void Start()
    {
        isThisGameOver = false;
        //makes sure pause menu isn't on at the start
        //UI.GetComponentInChildren<Canvas>().enabled = false;
        maxStress = 100;
        stressGrowthRate = 0f;
        startTime = DateTime.Now;
        gameOverCanvas.SetActive(false);
    }
    private int calculateScore()
    {
        return ((int)avgSpeed * 10) + (minigamesCompleted * 10) + (int)time * 100 + ((int)highestSpeed * 10); 
    }
    private void avergSpeed()
    {
        if(highestSpeed < CarController.CurrentSpeed)
        {
            highestSpeed = CarController.CurrentSpeed;
        }
        count++;
        if (count > avgInt)
        {
            avgSpeed = avgSpeed + ((int)CarController.CurrentSpeed - avgSpeed) / (avgInt + 1);
        }
        else
        {
            avgSpeed += (int)CarController.CurrentSpeed;
            if (count == avgInt)
            {
                avgSpeed += avgSpeed / count;
            }

        }
    }

    private void GameOver()
    {
        calculateScore();
        Debug.Log("here");
        gameOverCanvas.SetActive(true);
        //do anything else including propper menus reeset, etc
    }

    private void isGameOver()
    {
        Debug.Log((int)stressTime>stressMaxTime);
        if((int)stressTime > stressMaxTime )
        {
            isThisGameOver = true;
            GameOver();
            calculateScore();
        }
    }
    private void growStress()
    {
        stressGrowthRate = Mathf.Clamp(stressGrowthRate, 0, maxStressGrowthRate);
<<<<<<< HEAD
<<<<<<< HEAD
        if (stressAtMax)
        {
            stressTime += Time.deltaTime;
        }
        else
        {
            stressTime = 0;
        }
=======
        Debug.Log(stressGrowthRate);
>>>>>>> parent of 7295ffa... Revert "Trying to fix prefab"
=======
        Debug.Log(stressGrowthRate);
>>>>>>> parent of 7295ffa... Revert "Trying to fix prefab"
        if (stressGrowthRate > 0)
        {
            if (!stressAtMax)
            {

                stress += stressGrowthRate;
            }
        }
        else
        {
            if (stress > 0)
            {
                stress -= stressDecayRate;
            }
        }
        if(stress < maxStress)
        {
            stressAtMax = false;
        }
        else
        {
            stressAtMax = true;
        }
    }


    bool tenCheck = true;
    //Update stress as long as its not above max, and not less than 0
    void Update()
    {
        isGameOver();
        growStress();
        avergSpeed();
        Debug.Log("AtmaxStress: " +stressAtMax);
        time += Time.deltaTime;
        //Debug.Log(avgSpeed);

       
    }

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

