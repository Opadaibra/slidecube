using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverightleft : MonoBehaviour
{
    public bool moverigh;
    public bool moveleft;
  
    // Update is called once per frame
    void Update()
    {
        if(moveleft)
        {
            transform.position += Vector3.left * Time.deltaTime * 5;
            StartCoroutine(left());
        }
        if(moverigh)
        {
            transform.position += Vector3.right * Time.deltaTime * 5;
            StartCoroutine(right());
        }
    }
    IEnumerator left()
    {
        moverigh = false;
        moveleft = true;
        yield return new WaitForSeconds(1.5f);
        moveleft = false;
        moverigh = true;
    }
    IEnumerator right()
    {
        moveleft = false;
        moverigh = true;
        yield return new WaitForSeconds(1.5f);
        moveleft = true;
        moverigh = false;
    }
}
