using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelRotate : MonoBehaviour
{
    public WheelCollider wc;
    Controls controllerTest;
    public float torque = 200;
    public int cruiseIncrease = 0;
    public bool frontWheel = false;
    public Vector2 steerVec;
    public float maxSteerAngle = 30;
    float steerMag = 0;
    void Start()
    {
        wc = this.GetComponent<WheelCollider>();
    }

    //Decides whether car should accelerate, deccelerate, or not move as well as what direction the wheels should face
    //If tehy are the front wheels
    void Go(float accel,float steering)
    {
        accel = Mathf.Clamp(accel, -1, 1);
        steering = Mathf.Clamp(steering, -1, 1) * maxSteerAngle;
        float thrustTorque = accel * torque;
        wc.motorTorque = thrustTorque;
        if (frontWheel)
        {
            wc.steerAngle = steering;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(wc.motorTorque);
        Go(cruiseIncrease,steerVec.x);
        steerMag += steerVec.x;

        //Tester code for brakes, intend to implement "natural" deceleration in lieu of brakes
        if (Input.GetKeyDown(KeyCode.Space))
        {
            wc.brakeTorque = 300;
            Debug.Log(wc.brakeTorque);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            wc.brakeTorque = 0;
        }
        
    }
    //Awake Method is used to setup player controller and callbacks
    private void Awake()
    {
        controllerTest = new Controls();
        controllerTest.BaseMovement.IncreaseCruise.performed += ctx => torque += 1;
        controllerTest.BaseMovement.Steer.performed += ctx => steerVec = ctx.ReadValue<Vector2>();
    }
    //Enable and disable are called to disable/enable input when the script is active
    private void OnEnable()
    {
        controllerTest.Enable();
    }
    private void OnDisable()
    {
        controllerTest.Disable();
    }
}
