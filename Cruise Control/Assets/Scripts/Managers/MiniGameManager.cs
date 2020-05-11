using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SingleTon Minigame manager, iterates through minigame list and updates them accordingly.
//Activates minigames at random if they are not already activated
public class MiniGameManager : MonoSingleton<MiniGameManager>
{
    
    public float miniGameGlobalTimer;
    public bool trigger = false;
    public MiniGame[] minigameList;
    public int activeMiniGames = 0;
    public int maxActiveMiniGames = 2;

    void Update()
    {
        miniGameGlobalTimer += Time.deltaTime;
        //Attempt to initialize minigame if 10 seconds have passed
        if (miniGameGlobalTimer  > 10)
        {

            if(activeMiniGames < maxActiveMiniGames)
            {
                int mg_index = Random.Range(0, minigameList.Length-1);
                //Debug.Log("Current mg index "+ minigameList[mg_index].IsPlaying);
                if (!minigameList[mg_index].IsPlaying)
                {
                    //Debug.Log(GameManager.stressGrowthRate);
                    minigameList[mg_index].MiniGameStart();
                }
            }
            miniGameGlobalTimer = 0;

        }
        for(int i = 0; i < minigameList.Length; i++)
        {
           if(minigameList[i].IsPlaying)
            {
                minigameList[i].Status();
               
            }
        }

        
    }
}
