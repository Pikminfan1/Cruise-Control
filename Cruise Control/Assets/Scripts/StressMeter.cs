using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StressMeter : MonoBehaviour
{
    private const float MAX_SPEED_ANGLE = 0;
    private const float ZERO_SPEED_ANGLE = 180;

    public Transform needleTransform;

    public Timer timer;

    //public float stress;
    private float stressMax;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerStats.stress);
        PlayerStats.stress = 0;
        stressMax = 100f;
        Debug.Log(PlayerStats.stress);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.time <= 0)
        {
            PlayerStats.stress += 0.2f;
        }
        PlayerStats.stress = Mathf.Clamp(PlayerStats.stress, 0f, stressMax);
        Debug.Log("Stress: " + PlayerStats.stress);
        needleTransform.eulerAngles = new Vector3(0, 0, GetMeterRotation());
    }

    protected void LateUpdate()
    {
        //freezing x and y rotation manually to 0 so they aren't messed with
        transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z);
    }

    //calculate angle needed to rotate needle based on current stress
    private float GetMeterRotation()
    {
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

        float speedNormalized = PlayerStats.stress / stressMax;

        return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
    }
}
