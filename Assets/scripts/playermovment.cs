using UnityEngine;

public class playermovment : MonoBehaviour
{
    Rigidbody rb;
    GameObject Playername;
     float forwordspeed=4000f;
     float sidewaysforse=70f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Playername = GameObject.FindWithTag("Player");
  
    }
    
    // Update is called once per frame
    void LateUpdate()        
    {
      //  if(Input.GetKeyDown(KeyCode.W))
        rb.AddForce(0, 0, forwordspeed * Time.deltaTime);
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).deltaPosition.x > 0.2f)
            {
                rb.AddForce(sidewaysforse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            }
            else if (Input.GetTouch(0).deltaPosition.x < -0.2f)
            {
                rb.AddForce(-sidewaysforse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            }
        }
         /*if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, 200 * Time.deltaTime, 0, ForceMode.Impulse);

        }*/
        if (rb.position.y<-1)
        {
            FindObjectOfType<Gamemanger>().EndGame();
        }

    }
}
