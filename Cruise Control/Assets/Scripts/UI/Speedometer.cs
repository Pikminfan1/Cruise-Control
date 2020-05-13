using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Class for Spedometer UI. Kinda hacked this together really quickly and it def doesnt work lol,
//Need to add Lerp for rotation, and possibly scale the rotation down. << rotation could also be calculated in a different way
//By reading the speed of the player instead of calculating it in here
public class Speedometer : MonoBehaviour
{
    public Rigidbody needleRB;

    private const float MAX_SPEED_ANGLE = -20;
    private const float ZERO_SPEED_ANGLE = 230;

    private float speedMax;
    private float speed;
    private float acceleration;
    // Start is called before the first frame update

    private void Awake()
    {
        speed = 0f;
        speedMax = 20;
        acceleration = 90f;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("Speed is " + needleRB.velocity.magnitude);
        needleRB.transform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());
        if (Input.GetKey(KeyCode.W))
        {
            speed += acceleration;
        }
        else
        {
            if (speed > 0)
            {
                speed -= acceleration;
            }
        }

        speed = Mathf.Clamp(speed, 0f, speedMax);
    }

    private float GetSpeedRotation()
    {
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

        float speedNormalized = speed / speedMax;

        return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
    }
}
