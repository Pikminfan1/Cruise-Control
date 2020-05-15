using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeScript : MonoBehaviour
{
    public Image gauge;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //testing gauge
        if (GameManager.stress > 50)
        {
            DecreaseGauge();
        }
        else if (GameManager.stress > 10 && GameManager.stress < 50)
        {
            IncreaseGauge();
        }
    }

    public void IncreaseGauge()
    {
        if(Time.timeScale == 1.0f)
            gauge.fillAmount += 0.001f;
    }

    public void DecreaseGauge()
    {
        if(Time.timeScale == 1.0f)
            gauge.fillAmount -= 0.001f;
    }
}
