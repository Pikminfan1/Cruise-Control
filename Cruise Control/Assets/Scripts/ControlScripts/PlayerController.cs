using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script will eventually be used for actions that don't involve driving such as the wind shield wipers and windows
public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRB;
    //public PlayerStats stats;
    //Controls controllerTest;

    Controls controllerTest;
    Vector2 lookRaw;
    
    

    
    private void Awake()
    {
        PlayerRB = GetComponent<Rigidbody>();
        //stats.test = true;

        controllerTest = new Controls();
        controllerTest.BaseMovement.Move.performed += ctx => lookRaw = ctx.ReadValue<Vector2>();
    }
    private void OnEnable()
    {
        controllerTest.Enable();
    }
    private void OnDisable()
    {
        controllerTest.Disable();
    }

    //Method purpose is to determine if the player is rotating the joystick and in which direction in order to roll the window up or down
    bool isCounterClockwise(Vector2 prevPos, Vector2 currPos)
    {
        float prevAngle = Vector2.Angle(Vector2.zero, prevPos);
        float currAngle = Vector2.Angle(Vector2.zero, prevPos);

        if(currAngle >= 0 && currAngle <= 45 && 
            prevAngle <= 359 && prevAngle>= 315)
        {
            return true;
        }
        else
        {
            if(currAngle - prevAngle > 0)
            {
                return true;
            }
        }
        return false;
    }
    
    
}
