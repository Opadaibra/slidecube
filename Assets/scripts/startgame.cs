
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    public GameObject continuebutton;
    public GameObject panel;
    public GameObject Exitpanel;
    public GameObject Settingbutton;
    public GameObject closesettingbutton;
    public GameObject MuteSoundbut;
    public GameObject UnMuteSoundbut;
    public GameObject  playerbutton;
    public GameObject closeplayerbutton;
    public GameObject cube;
    public GameObject sphere;

    public void newpanel()
    {
        if (PlayerPrefs.GetInt("continue", 1) > 1)
            panel.SetActive(true);
        else
            Invoke("newgame", 0f);
    }
    public void ShowMutebutton()
    {
        closesettingbutton.SetActive(true);
        MuteSoundbut.SetActive(true);
        Settingbutton.SetActive(false);
    }
    public void Showplayers()
    {
        playerbutton.SetActive(false);
        closeplayerbutton.SetActive(true);
        cube.SetActive(true);
        sphere.SetActive(true);
    }
    public void hideplayers()
    {
        playerbutton.SetActive(true);

        closeplayerbutton.SetActive(false);
        cube.SetActive(false);
        sphere.SetActive(false);
    }
    public void HideMutebutton()
    {
        closesettingbutton.SetActive(false);
        Settingbutton.SetActive(true);
        MuteSoundbut.SetActive(false);
        UnMuteSoundbut.SetActive(false);


    }
    public void MuteSound()
    {
        MuteSoundbut.SetActive(false);
        UnMuteSoundbut.SetActive(true);
        FindObjectOfType<AudioManger>().mute("Theme");
    }
    public void UnMuteSound()
    {
        MuteSoundbut.SetActive(true);
        UnMuteSoundbut.SetActive(false);
        FindObjectOfType<AudioManger>().Unmute("Theme");
    }
    public void exitpanel()
    {
        Exitpanel.SetActive(true);
    }
    public void closepanel()
    {
        panel.SetActive(false);
    }
    public void closeexitpanel()
    {
        Exitpanel.SetActive(false);
    }
    private void Start()
    {
       // continuebutton = GameObject.Find("Continue");
        // newgamepanel.gameObject.SetActive(false);
        
        if(continuebutton == null||panel ==null)
        {
            Debug.LogWarning("There is no continue");
            Debug.LogWarning("There is no continue");
        }
        if (PlayerPrefs.GetInt("continue", 1) == 1)
        {
            continuebutton.SetActive(false);
        }
        if(PlayerPrefs.GetInt("continue", 1) > 1)
        {
            continuebutton.SetActive(true);

        }


    }
    public void Level(int level)
    {
        SceneManager.LoadScene(level +1);
    }
    
    public void newgame()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("sad", 0);
    }
    public void Credit()
    {
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 2);
    }
    public void Continue()
    {

        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings-1);
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Endgame()
    {
        Application.Quit();
    }
}
