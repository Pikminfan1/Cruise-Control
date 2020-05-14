using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//I don't do anything yay
public class EventManager : MonoSingleton<EventManager>
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public event Action onSignHit;
    public void SignHit()
    {
        Debug.Log("Sign Hit");
        if(onSignHit != null)
        {
            onSignHit();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
