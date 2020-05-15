using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Interact
{
    static public bool isEaten;
    //static public bool isEating;
    static public GameObject burger;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        CanUse = true;
        CanGrab = true;
        interactName = "Eat Food";
        burger = GameObject.Find("Burger_InteractableObject");
        burger.SetActive(false);
        //isEating = false;
        Appear();
    }

    public static void Appear()
    {
        //Probably change to an instantiate instead
        burger.SetActive(true);
        isEaten = false;
    }

    public static void Eat()
    {
        GaugeScript.Instance.IncreaseGauge();
        //isEating = true;
    }

    public override void Use()
    {
        Eat();
        resetHighLight();
    }

    public override void highLight()
    {
        if (!isEaten)
        {
            base.highLight();
        }
    }
}
