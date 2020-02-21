using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Character", menuName = "Scriptable Objects/Player Stats")]
//Scriptable Object for Player Attributes
//Things that may need to be accessed by multiple scripts should live here.
//Remember, anything written to an SO will persist after runtime, use an Awake or Start method in scripts that inherit this so
//To ensure the scene starts with the intended values.
//SOs do not live in the scenes, so they have no way to reference other actors in the scene
public class PlayerStats : ScriptableObject
{
    //Float to represent current stress level
    public float stress = 100;
    //Float to represent current speed
    public float currentSpeed;
    //Float to represent the "cruise" speed the car is attempting to reach
    public float cruiseSpeed;
    //Bool to store whether the window can be rolled up or not
    public bool isWindowRollToggle = false;
    //Used to determine how open the windows are
    public float windowOpenRatio;
    //Used to determine torque applied to brakes
    public float brakeTorqueSpeed;

    public void Awake()
    {
        isWindowRollToggle = false;

    }


}
