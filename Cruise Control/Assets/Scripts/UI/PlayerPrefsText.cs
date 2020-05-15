using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsText : MonoBehaviour
{

    //public int speed;
    //public float thirst;
    //public float hunger;
    public string number;
    public string words;

    // Update is called once per frame
    void Update()
    {
        // speed = (int)CarController.CurrentSpeed;
        if(!number.Equals("None"))
            GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetFloat(number) + "";
        if(!words.Equals("None"))
            GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetString(words) + "";
    }
}
