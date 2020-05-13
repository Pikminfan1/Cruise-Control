using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script used to drive wheel colliders
//Currently designed to be attatched to every wheel individually, with some heirachy changes
//In the editor, this script should be used to control all 4 at once.
public class wheelRotate : MonoBehaviour
{
    //Holds wheel colider
    public WheelCollider[] wc;
    //Reference to player controller
    ////Float value of speed of the wheel
    //public float speed = 0;
    //private float targetSpeed = 0;
    //Float value for current torque speed
    public float torque = 200;
    //Number torque should increase to until it is reached
    public int cruiseIncrease = 0;
    //Flag used to determine whether the wheel should be able to turn (this will be moved to a tag in the future)
    public bool frontWheel = false;
    //Raw vector pulled from left joystick
    public Vector2 steerVec;
    //Max angle allowed for steering
    public float maxSteerAngle = 30;
    //Used to judge how far to steer
    float steerMag = 0;
    //Used to determine direction of acceleration
    public float accelerationDirection = 0;

    //Start gets the wheelCollider component


    //Decides whether car should accelerate, deccelerate, or not move as well as what direction the wheels should face
    //If they are the front wheels
    void Go(float accel,float steering)
    {
        accel = Mathf.Clamp(accel, -1, 1);
        steering = Mathf.Clamp(steering, -1, 1) * maxSteerAngle;
        float thrustTorque = accel * torque;
        for (int i = 0; i < 4; i++)
        {
            wc[i].motorTorque = thrustTorque;
            if (i < 2)
            {
                wc[i].steerAngle = steering;
            }


            if (ButtonActionManager.LeftBumperIsDown)
            {
                //wc[i].brakeTorque = 300;
                accelerationDirection = 0;
                Debug.Log(wc[i].brakeTorque);
            }
            if (ButtonActionManager.LeftTriggerIsDown)
            {
                wc[i].brakeTorque = 0;
            }
        }
    }
    //Fixed Update will call y
    void FixedUpdate()
    {

        accelerationDirection += ButtonActionManager.RightTriggerValue;
        //Debug.Log(wc.motorTorque);
        //Set to auto accelerate currently
        steerVec = ButtonActionManager.LeftStickDirection;
        Go(accelerationDirection,steerVec.x);
        steerMag += steerVec.x;

        //Tester code for brakes, intend to implement "natural" deceleration in lieu of brakes
        
        
    }



}
