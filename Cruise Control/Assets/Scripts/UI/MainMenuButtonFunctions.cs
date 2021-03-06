﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonFunctions : MonoBehaviour
{
    //Quits game for when the quit button is pressed
    public void Quit()
    {
        Application.Quit();
    }

    //Goes to the game when Play button is pressed
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    //public void Options()
    //{

    //}

    //public void Controls()
    //{

    //}

    public static void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void Title()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadScene(int a)
    {
        SceneManager.LoadScene(a);
    }
    public void Reload()
    {
        LevelLayoutGenerator.pool.Clear();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
