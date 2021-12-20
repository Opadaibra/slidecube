using UnityEngine;
using UnityEngine.SceneManagement;

public class loadlevel : MonoBehaviour
{
  
    public void Start()
    {
        
        Invoke("loadnextlevel", 1f);
    }
 
    public void loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        int temp = PlayerPrefs.GetInt("sad");
          if(SceneManager.GetActiveScene().buildIndex > temp)
            {
               PlayerPrefs.SetInt("sad",SceneManager.GetActiveScene().buildIndex);
            }
 
    }



}
