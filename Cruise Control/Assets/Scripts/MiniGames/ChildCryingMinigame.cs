using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Minigame for crying child in back seat, This is an example of a minigame with interaction
//inside the cabin, with out grabbing an object
//
public class ChildCryingMinigame : MiniGame
{
    public new float StressDelta;

    private string title;
    private string description;

    private void Start()
    {

    }
    //Called to set stressgrowth delta back to the value it was
    //Before incrimenting by delta
    //Flags Playing to false and complete to true
    public override void MiniGameEnd()
    {
        //Set touchscreen texts back to initial once minigame ends
        PlayerPrefs.SetString("Title", "Cruise Control");
        PlayerPrefs.SetString("Description", "");

        IsPlaying = false;
        IsComplete = true;
        GameManager.stressGrowthRate -= StressDelta;
    }

    //Initializes the child crying loop and playing and complete flags
    //The stress delta is added to the growth rate 
    public override void MiniGameStart()
    {
        Debug.Log("ChildCrying Minigame");
        //Initialize title and description
        title = "Are We There Yet?";
        description = "The kids in the backseat are yelling at you. \n" +
            "Whip your head around to yell at them, but \n" +
            "make sure you know what’s in front of you.";

        //Set minigame title and description on touchscreen
        PlayerPrefs.SetString("Title", title);
        PlayerPrefs.SetString("Description", description);

        StressDelta = 0.25f;
        ChildCry.startCrying();
        IsPlaying = true;
        IsComplete = false;
        GameManager.stressGrowthRate += StressDelta;
        Debug.Log(GameManager.stressGrowthRate);
    }

    //Check if the child is crying and end the minigame if they are done
    public override void Status()
    {
        if (!ChildCry.isCrying)
        {
            
            MiniGameEnd();
        }
    }

}
