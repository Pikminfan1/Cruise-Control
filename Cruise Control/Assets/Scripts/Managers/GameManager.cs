using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoSingleton<GameManager>
{
    private static float _maxStress;
    public UIManager UI;
    public static float stress;
    public static float stressGrowthRate = 0.00f;
    public static float stressDecayRate = 0.05f;
    public float maxStressGrowthRate = 1.0f;
    public static bool stressAtMax = false;
    public static float maxStress;
    // Start is called before the first frame update
    void Start()
    {

        //makes sure pause menu isn't on at the start
        //UI.GetComponentInChildren<Canvas>().enabled = false;
        maxStress = 100;
        stressGrowthRate = 0f;
    }



    //Update stress as long as its not above max, and not less than 0
    void Update()
    {
        stressGrowthRate = Mathf.Clamp(stressGrowthRate, 0, maxStressGrowthRate);
        //Debug.Log(stressGrowthRate);
        if (stressGrowthRate > 0)
        {
            if (stress < maxStress)
            {
                
                stress += stressGrowthRate;
            }
        }
        else
        {
            if (stress > 0)
            {
                stress -= stressDecayRate;
            }
        }
    }

    public void TogglePauseMenu()
    {
        if (UI.GetComponentInChildren<Canvas>().enabled)
        {
            //turn pause menu off
            UI.GetComponentInChildren<Canvas>().enabled = false;
            Time.timeScale = 1.0f;
        }
        else
        {
            //turn pause menu on
            UI.GetComponentInChildren<Canvas>().enabled = true;
            Time.timeScale = 0f;
        }

        Debug.Log("GAMEMANAGER:: TimeScale: " + Time.timeScale);
    }
    
}
