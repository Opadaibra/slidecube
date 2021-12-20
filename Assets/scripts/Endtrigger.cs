using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public Gamemanger gamemanger;
    public playermovment playermovment;
    private void OnTriggerEnter()
    {
        
        gamemanger.winingGame();playermovment.enabled = false;
    }
}
