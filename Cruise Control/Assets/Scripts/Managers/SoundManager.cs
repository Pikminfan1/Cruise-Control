using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource soundFX;

    //Plays engine sound on a loop
    public AudioClip carEngine;
    public void carEngineSound()
    {
        soundFX.playOnAwake = true;
        soundFX.loop = true;
        soundFX.clip = carEngine;
        soundFX.volume = 0.06f;
        soundFX.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        carEngineSound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
