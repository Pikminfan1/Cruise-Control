using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreScreen : MonoBehaviour
{
    public List<GameObject> things;

    float count;
    void Start()
    {
        

    }
    //It was gonna be cool I swear but i had to do this to get it to 
    //work for now lmao
    void activateScreen()
        
    {
        int mult = (int)(((int)GameManager.time / 100));
        if (mult < 1)
        {
            mult = 1;
        }
        int score = ((GameManager.Instance.minigamesCompleted*100) + ((int)GameManager.Instance.highestSpeed*10) + ((int)GameManager.Instance.avgSpeed)*10)*mult;
        things[0].GetComponent<Text>().text = (int)GameManager.Instance.highestSpeed +" x 1 0";    
        things[1].GetComponent<Text>().text = (int)GameManager.Instance.avgSpeed +" x 1 0";
        things[2].GetComponent<Text>().text = "x "+(int)(((int)GameManager.time / 10)) + "";
        things[4].GetComponent<Text>().text = GameManager.Instance.minigamesCompleted + " x 1 0 0";
        things[3].GetComponent<Text>().text = score + "";     
            //things[5].GetComponent<Text>().text = "";     
    }
    IEnumerator waitScoreTime()
    {
        yield return new WaitForSeconds(1000000000.0f);
    }


    // Update is called once per frame
    void Update()
    {
        if (GameManager.isThisGameOver)
        {
            activateScreen();
        }
       
    }
}
