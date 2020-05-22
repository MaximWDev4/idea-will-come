using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeValuePannel : MonoBehaviour
{
    public Toggle toggle;
    public Slider slider;
    public AudioMixerGroup mixer;

    private void Start() {
        toggle.isOn = PlayerPrefs.GetInt("MusicEnabled") == 1;
        slider.value = PlayerPrefs.GetFloat("MasterVolume");
    }

    public void ToggleMusic(bool enable){
        if (enable){
            mixer.audioMixer.SetFloat("MusicVolume",0);
        } else {
            mixer.audioMixer.SetFloat("MusicVolume",-80);
        }

        PlayerPrefs.SetInt("MusicEnabled", enable ? 1 : 0);
    }

    public void ChangeVolume(float val)
    {
        mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80,0,val));
        PlayerPrefs.SetFloat("MasterVolume", val);
    }



}
