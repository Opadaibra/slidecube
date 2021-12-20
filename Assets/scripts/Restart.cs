using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject pausebutton ;
    public GameObject playbutton;
   
    public void Exitgame()
    {
        SceneManager.LoadScene(0);
    }
    public void pause()
    {
        Time.timeScale = 0;
        pausebutton.gameObject.SetActive(false);
        playbutton.gameObject.SetActive(true);
    }
    public void Resum()
    {
        Time.timeScale = 1;
        pausebutton.gameObject.SetActive(true);
        playbutton.gameObject.SetActive(false);
    }

}
