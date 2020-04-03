using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script used to drive wheel colliders
//Currently designed to be attatched to every wheel individually, with some heirachy changes
//In the editor, this script should be used to control all 4 at once.
public class wheelRotate : MonoBehaviour
{
    //Holds wheel colider
    public WheelCollider wc;
    //Reference to player controller
    Controls controllerTest;
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
    void Start()
    {
        wc = this.GetComponent<WheelCollider>();
    }

    //Decides whether car should accelerate, deccelerate, or not move as well as what direction the wheels should face
    //If they are the front wheels
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
    //Fixed Update will call
    void FixedUpdate()
    {
        ////Update speed
        //Speedometer();
        //speed = Mathf.SmoothStep(speed, targetSpeed, 2 * Time.deltaTime); //Gradually increase/decrease speed
        //speed = Mathf.Clamp(speed, 0, speed);
        ////Displays speed of car for UI text SPEED (in PlayerPrefsText.cs)
        //PlayerPrefs.SetFloat("Speed", speed);

        //Debug.Log(wc.motorTorque);
        //Set to auto accelerate currently
        Go(accelerationDirection,steerVec.x);
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

    //public void Speedometer()
    //{
    //    float circ = 2.0f * 3.14f * wc.radius; //finds circumference of wheel
    //    float wheelRpm = (circ * wc.rpm) / 1000; //rpm in km

    //    float speedKmh = (circ * wheelRpm) * 60; //speed in kilometers per hour
    //    targetSpeed = speedKmh * 0.62f; //speed in mph
    //}
}
