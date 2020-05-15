using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stressMeter : MonoBehaviour
{
    private const float MAX_STRESS_ANGLE = 0;
    private const float ZERO_STRESS_ANGLE = 180;
    public Transform needleTransform;


    
    private float GetStressRotation()
    {
       
        float totalAngleSize = ZERO_STRESS_ANGLE - MAX_STRESS_ANGLE;

        float stressNormalized = GameManager.stress / GameManager.maxStress;
        return ZERO_STRESS_ANGLE - stressNormalized * totalAngleSize;
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GetStressRotation());
        needleTransform.eulerAngles = new Vector3(0, 0, GetStressRotation());
    }
    protected void LateUpdate()
    {
        //freezing x and y rotation manually to 0 so they aren't messed with
        transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z);
    }
}
