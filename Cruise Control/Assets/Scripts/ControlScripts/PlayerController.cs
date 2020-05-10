using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script will eventually be used for actions that don't involve driving such as the wind shield wipers and windows
public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRB;
    //public PlayerStats stats;
    //Controls controllerTest;

    
    Vector2 lookRaw;

    public float speed = 0;

    



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
    
    void FixedUpdate()
    {
        float targetSpeed = PlayerRB.velocity.magnitude * 3.6f; //km/hr
        targetSpeed *= 0.62f; //mph
        Debug.Log("Velocity mag" + PlayerRB.velocity.magnitude);
        speed = Mathf.SmoothStep(speed, targetSpeed, 2 * Time.deltaTime); //Gradually increase/decrease speed display
        speed = Mathf.Clamp(speed, 0, speed);
        speed = Mathf.Ceil(speed);
        //Displays speed of car for UI text SPEED (in PlayerPrefsText.cs)
        PlayerPrefs.SetFloat("Speed", speed);

        //Debug.Log(speed);
    }
}
