using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTextDisplay : MonoBehaviour
{
    private Text text;
    void Awake()
    {
        text = GetComponent<Text>();
        if (PlayerPrefs.GetString("name") != null)
        {
            text.text = "Thank you, " + PlayerPrefs.GetString("name");
        } else
        {
            text.text = "Thank you, adventurer";
        }
    }
}
