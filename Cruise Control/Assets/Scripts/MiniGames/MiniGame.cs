using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Abstract class That all minigames will inherit from.
//All minigames have a method run upon completion and initiation
//Stress Delta is the rate of change on the stress meter
//Status Is called during Update() to determine if the minigame is over
public abstract class MiniGame : MonoBehaviour
{
    public bool IsPlaying;
    public bool IsComplete;
    public string name;
    public string description;
    //public float StressDelta;
   // public abstract float StressDelta { get; set; }
    public virtual void Awake()
    {
        name = "NONE";
        description = "NONE";
        IsPlaying = false;
        IsComplete = false;
    }
    public abstract void MiniGameStart();
    public abstract void MiniGameEnd();

    public abstract void Status();

}
