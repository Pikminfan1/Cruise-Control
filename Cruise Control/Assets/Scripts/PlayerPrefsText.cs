using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsText : MonoBehaviour
{
    public string name;

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetFloat(name) + "";
    }
}
