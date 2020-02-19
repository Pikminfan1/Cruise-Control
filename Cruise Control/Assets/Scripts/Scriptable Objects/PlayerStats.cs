using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Character", menuName = "Scriptable Objects/Player Stats")]
public class PlayerStats : ScriptableObject
{
    public float stress = 100;
    public float currentSpeed;
    public float cruiseSpeed;
    public bool test = true;

    public void Awake()
    {
        test = true;
    }


}
