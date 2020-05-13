using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtrack : MonoBehaviour
{
    public AudioClip[] soundtrack;
    public AudioClip[] soundtrack2; //For when stress is over 50%
    public bool isOver = false; //stress is over 50%

    //public PlayerStats player;

    float fadeRate = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (!GetComponent<AudioSource>().playOnAwake)
        {
            GetComponent<AudioSource>().clip = soundtrack[Random.Range(0, soundtrack.Length)];
            //GetComponent<AudioSource>().volume = 0.01f;
            GetComponent<AudioSource>().Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<AudioSource>().isPlaying)
        {
            if (isOver == false)
            {
                GetComponent<AudioSource>().clip = soundtrack[Random.Range(0, soundtrack.Length)];
                GetComponent<AudioSource>().Play();
            }
            else
            {
                GetComponent<AudioSource>().clip = soundtrack2[Random.Range(0, soundtrack2.Length)];
                GetComponent<AudioSource>().Play();
            }

        }

        //stressCheck();

    }

    void stressCheck()
    {
        //if stress has just surpassed 50, crossfade audio 
        if(isOver == false && GameManager.stress > 50){
          isOver = true;
          crossfadeOver();
        }
        else if(isOver == true && GameManager.stress < 50)
        {
            //crossfadeUnder();
        }
        else{
          isOver = false;
        }
    }

    //crossfade to faster-paced song
    void crossfadeOver()
    {
        //lower current track volume to 0
        while(GetComponent<AudioSource>().volume > 0.1f)
        {
            GetComponent<AudioSource>().volume = Mathf.Lerp(GetComponent<AudioSource>().volume, 0.0f,fadeRate*Time.deltaTime);
        }

        GetComponent<AudioSource>().volume = 0.0f;

        ///play new track from soundtrack 2 and increase volume to 1
        GetComponent<AudioSource>().clip = soundtrack2[Random.Range(0, soundtrack2.Length)];
        GetComponent<AudioSource>().Play();

        while (GetComponent<AudioSource>().volume < 0.9f)
        {
            GetComponent<AudioSource>().volume = Mathf.Lerp(GetComponent<AudioSource>().volume, 1.0f, fadeRate * Time.deltaTime);
        }

        GetComponent<AudioSource>().volume = 1.0f;
    }
}
