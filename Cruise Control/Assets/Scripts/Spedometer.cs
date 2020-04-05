using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spedometer : MonoBehaviour
{
    private const float MAX_SPEED_ANGLE = -55;
    private const float ZERO_SPEED_ANGLE = 225;

    //used for updating the needle's transform values
    public Transform needleTransform;

    private float speedMax;
    private float speed;

    private GameObject carRB;
    private PlayerController pc;

    private void Awake()
    {
        carRB = GameObject.Find("carBody");
        pc = carRB.GetComponent<PlayerController>();
        speed = 0; //start speed
        speedMax = 200f;
    }

    private void Update()
    {
        ////for testing
        //HandlePlayerInput();

        //speed += 30f * Time.deltaTime;
        //if (speed > speedMax) speed = speedMax;

        //Speed of the car
        speed = pc.speed;
        speed = Mathf.Clamp(speed, 0f, speedMax);

        //rotates needle based on calculated speed
        needleTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());
    }

    protected void LateUpdate()
    {
        //freezing x and y rotation manually to 0 so they aren't messed with
        transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z);
    }

    ////testing function to see if speedometer works with input
    //private void HandlePlayerInput()
    //{
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        float acceleration = 50f;
    //        speed += acceleration * Time.deltaTime;
    //    }
    //    else
    //    {
    //        float deceleration = 20f;
    //        speed -= deceleration * Time.deltaTime;
    //    }

    //    if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        float brakespeed = 100f;
    //        speed -= brakespeed * Time.deltaTime;
    //    }

    //    //so needle stays in range of the speedometer numbers
    //    speed = Mathf.Clamp(speed, 0f, speedMax);
    //}

    //calculate angle needed to rotate needle based on current speed
    private float GetSpeedRotation()
    {
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

        float speedNormalized = speed / speedMax;

        return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
    }
}
