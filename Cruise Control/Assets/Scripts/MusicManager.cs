using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    public void SetVolume(float val)
    {
        GetComponent<AudioSource>().volume = val;
        Debug.Log("Volume: " + val);
    }
}
