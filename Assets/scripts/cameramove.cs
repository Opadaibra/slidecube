using UnityEngine;

public class cameramove : MonoBehaviour
{
     Transform player;
    public Vector3 offset;
    private void Start()
    {
        GameObject tempplayerref = GameObject.FindWithTag("Player");
     
        player = tempplayerref.transform;
    }
    void Update()
    {
        transform.position = player.position + offset;
    }
}
