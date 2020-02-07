using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRB;
    public int maxSpeed = 100;
    public float currentSpeed = 0f;
    public float turnSpeed = 5f;
    public float smoothing = 0.5f;

    public bool cruiseControlStatus = false;
    public int cruiseControlSpeed = 0;

    private void Awake()
    {
        PlayerRB = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // SUPER TEMPORARY PLEASE FORGIV ME These inputs should be replaced with 
    //Actual button mappins in the input manager, these are merely for prototyping
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (cruiseControlSpeed < maxSpeed)
            {
                cruiseControlSpeed += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(cruiseControlSpeed > 0)
            {
                cruiseControlSpeed -= 1;
            }

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerRB.transform.Rotate(new Vector3(0, 2));
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                PlayerRB.transform.Rotate(new Vector3(0, -2));
            }
        }

        PlayerRB.AddRelativeForce(Vector3.forward * cruiseControlSpeed);
        
    }
}
