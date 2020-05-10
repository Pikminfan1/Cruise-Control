using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsText : MonoBehaviour
{
    
    public int speed;

    // Update is called once per frame
    void Update()

    {
        speed = (int)CarController.CurrentSpeed;
        GetComponent<UnityEngine.UI.Text>().text = speed + "";
    }
}
