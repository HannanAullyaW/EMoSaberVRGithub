using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameOver gameOverScreen;
    public TextMeshProUGUI pointText;
    public GameObject gameOverUI;
    public GameObject rayLeft;
    public GameObject rayRight;
    public GameObject weaponLeft;
    public GameObject weaponRight;

    public void Setup(){
        
        gameOverUI.SetActive(true);
        
        pointText.text = Score.score.ToString() + " POINTS";
        rayLeft.SetActive(true);
        rayRight.SetActive(true);
        weaponLeft.SetActive(false);
        weaponRight.SetActive(false);
    }
    public void Restart(string namaScene){
        Time.timeScale = 1;
        gameOverUI.SetActive(false);
        
        SceneManager.LoadScene(namaScene);
   }
    public void MainMenu(){
        Time.timeScale = 1;
        BackgroundMusic.bgMusic.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("MainMenu");
        Debug.Log("loading..");
    }
}
