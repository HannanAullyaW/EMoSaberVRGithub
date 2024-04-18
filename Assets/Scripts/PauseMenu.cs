using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public static bool GameIsPaused = false;
   public GameObject PauseMenuUI;
    public GameObject rayLeft;
    public GameObject rayRight;
    public GameObject weaponLeft;
    public GameObject weaponRight;
   public InputActionProperty showButton;
    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame()){
            if(GameIsPaused){
                Resume();
            }else{
                Pause();
            }
        }
        
        // if (Input.GetKeyDown(KeyCode.Space)){
        //     if(GameIsPaused){
        //         Resume();
        //     }else{
        //         Pause();
        //     }
        // }
    }

    public void Resume(){
        PauseMenuUI.SetActive(false);
        rayLeft.SetActive(false);
        rayRight.SetActive(false);
        weaponLeft.SetActive(true);
        weaponRight.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause(){
        PauseMenuUI.SetActive(true);
        rayLeft.SetActive(true);
        rayRight.SetActive(true);
        weaponLeft.SetActive(false);
        weaponRight.SetActive(false);
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
