using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
   public void PlayGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void PlayGameSedih(){
    SceneManager.LoadScene("SedihScene");
   }

   public void PlayGameSenang(){
    SceneManager.LoadScene("SenangScene");
   }

   public void PlayGameTakut(){
    SceneManager.LoadScene("TakutScene");
   }

   public void PlayGameTerkejut(){
    SceneManager.LoadScene("TerkejutScene");
   }

   public void PlayGameMarah(){
    SceneManager.LoadScene("MarahScene");
   }
   public void QuitGame(){
      Debug.Log("Kelyuar");
      Application.Quit();
   }

   public void PengaturanGame(){
      SceneManager.LoadScene("PengaturanMenu");
   }

   public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
        Debug.Log("loading..");
    }

}
