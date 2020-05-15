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
    public UIManager pauseMenu;
    public static float stress;
    public static int score;
    public static float time;
    public static DateTime startTime;
    public static float stressGrowthRate = 0.00f;
    public static float stressDecayRate = 0.05f;
    public float maxStressGrowthRate = 1.0f;
    public static bool stressAtMax = false;
    public static float maxStress = 100;
    public float highestSpeed;
    public int minigamesCompleted;
    public int stressMaxTime = 10;
    public float stressTime;
    private float avgTimer;
    private int avgInt = 100;
    public float avgSpeed;
    private float count;
    public static bool isThisGameOver = false;
    public AudioSource gameFX;
    public AudioClip[] gameSounds;





    // Start is called before the first frame update
    void Start()
    {
        isThisGameOver = false;
        stress = 0;
        maxStress = 100;

        stressGrowthRate = 0f;
        startTime = DateTime.Now;
        //makes sure pause menu isn't on at the start
        pauseMenu.GetComponentInChildren<Canvas>().enabled = false;
  
        //gameOverCanvas.SetActive(false);
    }
    private int calculateScore()
    {
        return ((int)avgSpeed * 10) + (minigamesCompleted * 10) + (int)time * 100 + ((int)highestSpeed * 10);
    }
    private void avergSpeed()
    {
        if (highestSpeed < CarController.CurrentSpeed)
        {
            highestSpeed = CarController.CurrentSpeed;
        }
        count += Time.deltaTime;
        if((int)count > 2)
        {
            avgSpeed += CarController.CurrentSpeed;
            avgSpeed /= 2;
            count = 0;
        }
       
        /*
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

        }*/
    }

    private void GameOver()
    {

        calculateScore();
       // Debug.Log("here");
        gameOverCanvas.SetActive(true);
        //do anything else including propper menus reeset, etc
    }

    private void isGameOver()
    {

        if ((int)stressTime > (int)stressMaxTime)
        {
            isThisGameOver = true;
            GameOver();
            calculateScore();
        }
    }
    private void growStress()
    {
        stressGrowthRate = Mathf.Clamp(stressGrowthRate, 0, maxStressGrowthRate);
        //Debug.Log(stressAtMax);
        if (stress >= maxStress)
        {
            stressAtMax = true;
        }
        else
        {
            stressAtMax = false;
        }
        if (stressAtMax)
        {
            stressTime += Time.deltaTime;
        }
        else
        {
            if (stressGrowthRate <= 0)
            {
                stressTime = 0;
            }
        }
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

    }
    bool tenCheck = true;
    //Update stress as long as its not above max, and not less than 0
    void Update()
    {
        //Debug.Log(ButtonActionManager.StartButtonIsDown);
        growStress();
        isGameOver();
        if (!isThisGameOver)
        {
            gameOverCanvas.SetActive(false);
            avergSpeed();
        }
        Debug.Log("AtmaxStress: " + stressAtMax);
        time += Time.deltaTime;
        //Debug.Log(avgSpeed);

    }

    public void TogglePauseMenu()
    {
        if (pauseMenu.GetComponentInChildren<Canvas>().enabled)
        {
            //turn pause menu off
            pauseMenu.GetComponentInChildren<Canvas>().enabled = false;
            Time.timeScale = 1.0f;
        }
        else
        {
            //turn pause menu on
            pauseMenu.GetComponentInChildren<Canvas>().enabled = true;
            Time.timeScale = 0f;
        }

        Debug.Log("GAMEMANAGER:: TimeScale: " + Time.timeScale);
    }

}
