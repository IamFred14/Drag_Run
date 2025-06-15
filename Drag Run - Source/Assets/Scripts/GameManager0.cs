using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager0 : MonoBehaviour
{

    public static bool GameIsPaused = false;
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject playerUI;
    public GameObject pauseMenuUI;


    public void EndGame() {

        if(gameHasEnded == false){

            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);

        }

    }

    void Restart(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        


    }

    public void CompleteLevel(){


        completeLevelUI.SetActive(true);
        playerUI.SetActive(false);
        Invoke("LoadNextLevel", 1);

    }
    public void LoadNextLevel(){
    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){

            if (GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    
    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;

    }

    public void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;

        
    }
}

