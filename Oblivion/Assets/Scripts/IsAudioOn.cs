using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAudioOn : MonoBehaviour
{


    public GameObject Audio;

    public int AudioPref;



    void Start()
    {
        
     AudioPref = PlayerPrefs.GetInt("isaudioon");
     Debug.Log(AudioPref + "blah");

     if (AudioPref == 1) {

         Audio.SetActive(true);
         

     }

     if (AudioPref == 0) {

         Audio.SetActive(false);

     }

    }

    
    void Update()
    {
        
    }
}
