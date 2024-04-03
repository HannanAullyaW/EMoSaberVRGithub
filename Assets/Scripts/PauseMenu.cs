using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public bool GameIsPaused = false;
   public GameObject PauseMenuUI;
    public GameObject rayLeft;
    public GameObject rayRight;
    public GameObject weaponLeft;
    public GameObject weaponRight;
   public InputActionProperty showButton;
    // Update is called once per frame
    void Update()
    {
        if (GameIsPaused == false)
        {
            Time.timeScale = 1;
        }
        if (showButton.action.WasPressedThisFrame()){
            if(GameIsPaused){
                Time.timeScale = 1;
                Resume();
                GameIsPaused = false;
            }else{
                Time.timeScale = 0;
                Pause();
                GameIsPaused = true;
                
            }
        }

        if (Input.GetKeyDown((KeyCode.Space))){
            if(GameIsPaused){
                Time.timeScale = 1;
                Resume();
                GameIsPaused = false;
            }else{
                Time.timeScale = 0;
                Pause();
                GameIsPaused = true;
                
            }
        }

        
        
    }

    public void Resume(){
        PauseMenuUI.SetActive(false);
        rayLeft.SetActive(false);
        rayRight.SetActive(false);
        weaponLeft.SetActive(true);
        weaponRight.SetActive(true);
       
        GameIsPaused = false;
    }

    public void Pause(){
        
        PauseMenuUI.SetActive(true);
        rayLeft.SetActive(true);
        rayRight.SetActive(true);
        weaponLeft.SetActive(false);
        weaponRight.SetActive(false);
        
    }

    public void MainMenu(){
        BackgroundMusic.bgMusic.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("MainMenu");
        Debug.Log("loading..");
    }

    public void QuitGame(){
        Debug.Log("Keluyar");
        Application.Quit();
    }
    public void Restart(string namaScene){
    SceneManager.LoadScene(namaScene);
   }
}
