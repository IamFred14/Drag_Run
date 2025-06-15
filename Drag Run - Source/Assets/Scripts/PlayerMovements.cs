using UnityEngine;

public class PlayerMovements : MonoBehaviour
{   
    public Rigidbody rb;

    public float forwardForce;
    public float sidewaysForce;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")){
            rb.AddForce(-(sidewaysForce * Time.deltaTime), 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s")){
            rb.AddForce(0, 0, -(forwardForce * Time.deltaTime));
        }
        if(rb.position.y < 1f){

            FindObjectOfType<GameManager0>().EndGame();
        }
        
    }

    
}
