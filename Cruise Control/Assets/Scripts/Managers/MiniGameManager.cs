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
    public int currentMaxTime = 10;
    bool secondCheck = true;
    void updateMinigameCount()
    {
        Debug.Log(GameManager.Instance.minigamesCompleted);
        GameManager.Instance.minigamesCompleted++;
        return;
    }

    private void FixedUpdate()
    {
        float timeTest = GameManager.time;
        if (currentMaxTime > 3)
        {
            if ((int)timeTest % 30 == 29&&secondCheck)
            {
                currentMaxTime -= 2;
                secondCheck = false;
            }if((int)timeTest %31 == 30 && !secondCheck)
            {
                secondCheck = true;
            }
        }
    }
    void Update()
    {
        

        miniGameGlobalTimer += Time.deltaTime;
        //Attempt to initialize minigame if 10 seconds have passed
        if (miniGameGlobalTimer  > currentMaxTime)
        {

            if(activeMiniGames < maxActiveMiniGames)
            {
                int mg_index = Random.Range(0, minigameList.Length-1);
                Debug.Log("Current mg index "+ minigameList[mg_index].IsPlaying);
                Debug.Log("Minigame #: " + mg_index);
                if (!minigameList[mg_index].IsPlaying)
                {
                    Debug.Log("I MADE IT");
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
                if (GameManager.isThisGameOver)
                {
                    minigameList[i].IsPlaying = false;
                }

            }
            else
            {
                if (minigameList[i].IsComplete)
                {
                    
                    minigameList[i].IsComplete = false;
                    updateMinigameCount();
                }
            }
        }

        
    }
}
