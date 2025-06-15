using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public int scoreValue;
    public Transform player;
    public Text scoreText;
  
    void Update()
    {
        scoreValue = (int)player.position.z;
        scoreText.text = scoreValue.ToString("0");
        
    }
}
