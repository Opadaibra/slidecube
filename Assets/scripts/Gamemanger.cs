using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemanger : MonoBehaviour
{
  
    bool gamehasEnded = false;
    public GameObject CompletelevelUI;
    public Material material;
    public Material material2;
    public GameObject Finishpoint;
    public Color[] colors;
    public GameObject[] Players; 
    public Text Level;

    private void Start()
    {
   
        GameObject Player = Instantiate(Players[PlayerPrefs.GetInt("playertype",1)], transform.position, Quaternion.identity);
        getlevel();
        FindObjectOfType<LevelBar>().SetMaxHealth(Finishpoint.transform.position.z);
        int x = Random.Range(0, colors.Length-1);
        while(x%2 !=0)
        {
            x = Random.Range(0, colors.Length-1);
        }
        if(x % 2 ==0)
        {
            material2.color = colors[x];
            material.color = colors[x+1];
        }
        if(SceneManager.GetActiveScene().buildIndex > 0 )
            PlayerPrefs.SetInt("continue", SceneManager.GetActiveScene().buildIndex);
    }
    public void winingGame()
    {
        CompletelevelUI.SetActive(true);
   
    }
    public void EndGame()
    {
        if(!gamehasEnded)
        {
            gamehasEnded = true;
            Debug.Log("GAMEOVER");
            //restartgame();
            Invoke("restartgame", 2f);
            //restart game
        }
    }
    public void getlevel()
    {
        //int x = 
        Level.text = SceneManager.GetActiveScene().name;
    }
    void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

 
}
