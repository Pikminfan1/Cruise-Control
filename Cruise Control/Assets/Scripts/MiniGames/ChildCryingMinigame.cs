using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Minigame for crying child in back seat, This is an example of a minigame with interaction
//inside the cabin, with out grabbing an object
//
public class ChildCryingMinigame : MiniGame
{
    public new float StressDelta;
    private void Start()
    {
        
    }
    //Called to set stressgrowth delta back to the value it was
    //Before incrimenting by delta
    //Flags Playing to false and complete to true
    public override void MiniGameEnd()
    {
        IsPlaying = false;
        IsComplete = true;
        GameManager.stressGrowthRate -= StressDelta;
    }

    //Initializes the child crying loop and playing and complete flags
    //The stress delta is added to the growth rate 
    public override void MiniGameStart()
    {
        StressDelta = 0.034f;
        ChildCry.startCrying();
        IsPlaying = true;
        IsComplete = false;
        GameManager.stressGrowthRate += StressDelta;
        //Debug.Log(GameManager.stressGrowthRate);
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
