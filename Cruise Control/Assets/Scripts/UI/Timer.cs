using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //public GameObject stressMeter;

    private float timeLeft;
    public int time;

    private int tempTime;

    // Start is called before the first frame update
    void Start()
    {
        tempTime = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0) {
            timeLeft -= Time.deltaTime;

        }
        if (timeLeft <= 0)
        {
            timeLeft = tempTime;
        }
        time = (int) (timeLeft % 60);
        PlayerPrefs.SetFloat("Time", time);
    }
}
