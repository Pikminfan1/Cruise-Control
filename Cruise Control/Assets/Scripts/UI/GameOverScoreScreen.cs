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
        things[0].GetComponent<Text>().text = (int)GameManager.Instance.highestSpeed +"";    
            things[1].GetComponent<Text>().text = (int)GameManager.Instance.avgSpeed +"";
            things[2].GetComponent<Text>().text = (int)(((int)GameManager.time / 10)*10) + "";  
            //things[3].GetComponent<Text>().text = "";     
            //things[4].GetComponent<Text>().text = "";     
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
