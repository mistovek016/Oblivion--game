using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    // Update is called once per frame
    public void Restart1()
    {
        
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        
    }

    public void NextLevel()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
