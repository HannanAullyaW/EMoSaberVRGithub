using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time;
    public GameOver GameOverScreen;
    public TextMeshProUGUI timeText;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(time > 0){
            // Time.timeScale = 1;
            time -= Time.deltaTime;
        }
        else if(time <= 0){
            Time.timeScale = 0;
            time = 0;
            GameOverScreen.Setup();
            
        }
        int minutes = Mathf.FloorToInt(time/60);
        int seconds = Mathf.FloorToInt(time%60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
