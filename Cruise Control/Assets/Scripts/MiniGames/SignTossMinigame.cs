using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignTossMinigame : MiniGame {
    public static SignTossMinigame Instance;
    public override void Awake()
    {
        Instance = this;
        IsPlaying = true;
        EventManager.Instance.onSignHit += SignCollision;
    }

    private void Start()
    {
       
    }

    public void SignCollision()
    {
        //Instance = this;
        Debug.Log("SUCCESS");
        if (IsPlaying)
        {
            Debug.Log("SUCCESS");
        }
    }
    public override void MiniGameEnd()
    {
        IsPlaying = false;
    }

    public override void MiniGameStart()
    {
        IsPlaying = true;
    }

    public override void Status()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
