using UnityEngine;

public class playercollison : MonoBehaviour
{
     playermovment playermovment;
    private void Start()
    {
        playermovment = GetComponent<playermovment>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="obstcle")
        {
           
            playermovment.enabled = false;
            FindObjectOfType<Gamemanger>().EndGame();
        }
    }
}
