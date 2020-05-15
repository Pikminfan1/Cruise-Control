using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] relaxedTracks;
    public AudioClip[] mediumTracks;
    public AudioClip[] agressiveTracks;
    public AudioSource source1, source2;
    public DoubleAudioSource ds;
    private float volume;
    public float FadeDuration;
    public static MusicManager instance;

    private void Start()
    {
        ds = GetComponent<DoubleAudioSource>();
        instance = this;
    }
    public void pickTrack()
    {
        /*
        if(GameManager.stress < 33)
        {
            ds.CrossFade(relaxedTracks[Random.Range(0,relaxedTracks.Length)], .5f, 5f);
        }
        if (GameManager.stress > 33 && GameManager.stress < 66){
            ds.CrossFade(mediumTracks[Random.Range(0, mediumTracks.Length)], .5f, 5f);
        }
        if(GameManager.stress > 66) {
            ds.CrossFade(agressiveTracks[Random.Range(0, agressiveTracks.Length)], .5f, 5f);
        }
        */

    }
    public void SetVolume(float val)
    {
        GetComponent<AudioSource>().volume = val;
        Debug.Log("Volume: " + val);
    }
}