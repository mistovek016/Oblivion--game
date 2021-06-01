using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settingsmenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public GameObject audioSource;

    public GameObject settings;

    

    public void SetVolume(float volume)
    {
        //Debug.Log(volume);   
        audioMixer.SetFloat("volume", volume);

    }

    public void SetAudio(bool isAudioOn)
    {

        audioSource.SetActive(isAudioOn);

        if (isAudioOn == true) {

           PlayerPrefs.SetInt("isaudioon", 1);

        }

        if (isAudioOn == false) {

           PlayerPrefs.SetInt("isaudioon", 0);

        }

    
    }

    public void Mute() {

           AudioListener.pause = !AudioListener.pause;

        }

        public void Settings() {

           settings.SetActive(true);

        }

}
