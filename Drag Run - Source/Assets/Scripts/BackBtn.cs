using UnityEngine;
using UnityEngine.SceneManagement;


public class BackBtn : MonoBehaviour
{
    public void BackToHomeScreen(){
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync("HomeScreen");
    }
}
