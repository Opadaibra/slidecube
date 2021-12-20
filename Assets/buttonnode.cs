using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonnode : MonoBehaviour
{
    public GameObject[] button;

    int temp;
    public int  butonlimit;
    private void Start()
    {
       

        for (int i = 1;i <button.Length;i++)
        {
            button[i].SetActive(false);
        }
         temp = PlayerPrefs.GetInt("sad", 0);
        levelunlock();
    }
    public void level(int thislevel)
    {
        SceneManager.LoadScene(thislevel);
    }
    void levelunlock()
    {
        
        if(temp > 0 && temp <=butonlimit )
        {
            for(int i = 1;i <= temp;i++)
            {

                button[i].SetActive(true);
            }
        }
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
