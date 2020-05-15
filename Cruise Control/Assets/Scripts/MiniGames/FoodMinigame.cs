using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMinigame : MiniGame
{
    public new float StressDelta;

    private string title;
    private string description;

    // Start is called before the first frame update
    void Start()
    {
        MiniGameStart();
    }

    //Called to set stressgrowth delta back to the value it was
    //Before incrimenting by delta
    //Flags Playing to false and complete to true
    public override void MiniGameEnd()
    {
        //Set touchscreen texts back to initial once minigame ends
        PlayerPrefs.SetString("Title", "Cruise Control");
        PlayerPrefs.SetString("Description", "");
        PlayerPrefs.SetString("Gauge", "");

        IsPlaying = false;
        IsComplete = true;
        GameManager.stressGrowthRate -= StressDelta;
    }

    public override void MiniGameStart()
    {
        Debug.Log("Food Minigame");

        //Initialize title and description
        title = "Are You Hungry?";
        description = "You're so hungry. That burger looks really " +
            "tempting right now. Eat the burger but continue to drive safely!";

        //Set minigame title and description on touchscreen
        PlayerPrefs.SetString("Title", title);
        PlayerPrefs.SetString("Description", description);

        //Activate hunger gauge
        GaugeScript.Instance.Activate();
        PlayerPrefs.SetString("Gauge", "Hunger");

        StressDelta = 0.034f;
        //Food.Appear();
        IsPlaying = true;
        IsComplete = false;

        GameManager.stressGrowthRate += StressDelta;
        Debug.Log(GameManager.stressGrowthRate);

        if (GaugeScript.Instance.GetAmount() >= 1.0f)
        {
            Food.isEaten = true;
        }

    }

    public override void Status()
    {
        if (Food.isEaten)
        {
            MiniGameEnd();
        }
    }
}
