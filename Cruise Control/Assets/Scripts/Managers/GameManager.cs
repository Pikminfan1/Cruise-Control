using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoSingleton<GameManager>
{

    public UIManager UI;
    public static float stress;
    public static float stressGrowthRate = 0.01f;
    public static bool stressAtMax = false;
    public static float maxStress = 0;
    // Start is called before the first frame update
    void Start()
    {

        //makes sure pause menu isn't on at the start
        UI.GetComponentInChildren<Canvas>().enabled = false;
        maxStress = 100;
    }
    private void Awake()
    {
        maxStress = 100;
    }


    //// Update is called once per frame
    void Update()
    {
        stress += stressGrowthRate;
       // Debug.Log("STRESS IS"+(int) +stress);
        //Debug.Log("MAX STRESS"+(int)maxStress);
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
