using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerobjmanger : MonoBehaviour
{
    
    static public playerobjmanger instance;
     int playerindex;
    public void  playerBox()
    {
        PlayerPrefs.SetInt("playertype", 0);
    }
    public void playerspher()
    {
        PlayerPrefs.SetInt("playertype", 1);

    }

}
