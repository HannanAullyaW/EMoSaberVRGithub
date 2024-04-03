using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    // Start is called before the first frame update
       public  bool GameIsPaused;
   public GameObject PauseMenuUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKeyDown((KeyCode.Space))){
            if(GameIsPaused){
                Time.timeScale = 1;
                PauseMenuUI.SetActive(false);
                GameIsPaused = false;
            }else{
                Time.timeScale = 0;
                PauseMenuUI.SetActive(true);
                GameIsPaused = true;
                
            }
        }
    }
}
