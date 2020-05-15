using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeScript : MonoSingleton<GaugeScript>
{
    //public GameObject obj;
    public Image gaugeFill;
    //public GameObject gauge;
    public CanvasGroup gauge;

    public static GaugeScript Instance;

    void Awake()
    {
        Instance = this;
        //Deactivate();
    }

    // Start is called before the first frame update
    void Start()
    {
        //gauge = GameObject.Find("Gauge");
        //obj = GameObject.Find("fill_amount");
        //gaugeFill = obj.GetComponent<Image>();
        //Deactivate();
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    //testing gauge
    //    if (GameManager.stress > 50)
    //    {
    //        DecreaseGauge();
    //    }
    //    else if (GameManager.stress > 10 && GameManager.stress < 50)
    //    {
    //        IncreaseGauge();
    //    }
    //}

    public void IncreaseGauge()
    {
        if(Time.timeScale == 1.0f)
            gaugeFill.fillAmount += 0.05f;
    }

    public void DecreaseGauge()
    {
        if(Time.timeScale == 1.0f)
            gaugeFill.fillAmount -= 0.05f;
    }

    public void Activate()
    {
        gauge.alpha = 1f;
    }

    public void Deactivate()
    {
        gauge.alpha = 0f;
    }

    //how much of the gauge is filled (scaled 0.0f to 1.0f)
    public float GetAmount()
    {
        return gaugeFill.fillAmount;
    }
}
