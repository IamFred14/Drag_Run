using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager0 gameManager;

    void OnTriggerEnter() {
        gameManager.CompleteLevel();
        Debug.Log("Completed!");
        

    }
   
}
