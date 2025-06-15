using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
 
    void OnCollisionEnter(Collision collisionInfo) {

        if(collisionInfo.collider.tag == "Obstacle"){

            GetComponent<PlayerMovements>().enabled = false;
            FindObjectOfType<GameManager0>().EndGame();

        }
    }
}
