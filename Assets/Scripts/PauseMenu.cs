using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public static bool GameIsPaused = false;
   public GameObject PauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if(GameIsPaused){
                Resume();
            }else{
                Pause();
            }
        }
    }

    public void Resume(){
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause(){
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
        Debug.Log("loading..");
    }

    public void QuitGame(){
        Debug.Log("Keluyar");
        Application.Quit();
    }

    public void Restart(){
        SceneManager.LoadScene("tes prototipe");
    }
}
