using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameManager GM;
    public MusicManager MM;

    public Slider _musicSlider;
    public Toggle _musicToggle;

    // Start is called before the first frame update
    void Start()
    {

        //Music Settings Initialize
        //_musicSlider = GameObject.Find("Music_Slider").GetComponent<Slider>();
        //_musicToggle = GameObject.Find("Music_Toggle").GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        ScanForKeyStroke();
    }

    void ScanForKeyStroke()
    {
        //toggles pause menu when esc is pressed
        if (Input.GetKeyDown("escape"))
            GM.TogglePauseMenu();
    }

    //Music Settings Functions
    public void MusicSliderUpdate()
    {
        //Set volume based on music slider
        float val = _musicSlider.value;
        MM.SetVolume(val);
    }

    //Mutes/unmutes music
    public void MusicToggle(bool val)
    {
        if (_musicToggle.isOn)
            val = true;
        else
            val = false;
        _musicSlider.interactable = val;
        MM.SetVolume(val ? _musicSlider.value : 0f);
        _musicToggle.Select();
        Debug.Log("Toggle: " + val);
    }
}
