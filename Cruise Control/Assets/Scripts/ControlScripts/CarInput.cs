﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CarController))]
public class CarInput : MonoBehaviour
{
    private CarController m_Car; // the car controller we want to use
    private void Awake()
    {
        // get the car controller
        m_Car = GetComponent<CarController>();
    }

    private void FixedUpdate()
    {
        if (!GameManager.isThisGameOver)
        {
            // pass the input to the car!
            float h = ButtonActionManager.LeftStickDirection.x;
            float v = ButtonActionManager.RightTriggerValue;
            if (ButtonActionManager.RightBumperIsDown)
            {
                v *= -1;
            }
            float handbrake = ButtonActionManager.LeftTriggerValue;
            m_Car.Move(h, v, v, handbrake);
        }

    }
}
