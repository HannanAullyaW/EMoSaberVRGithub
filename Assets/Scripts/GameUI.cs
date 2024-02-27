using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{

   public void PlayGame(string namaScene){
    SceneManager.LoadScene(namaScene);
   }
   public void SelectLevel(string namaScene){
    SceneManager.LoadScene(namaScene);
   }
   public void SelectMateri(string namaScene){
    SceneManager.LoadScene(namaScene);
   }
   public void Pengaturan(string namaScene){
    SceneManager.LoadScene(namaScene);
   }
   public void QuitGame(){
      Debug.Log("Kelyuar");
      Application.Quit();
   }
    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
        Debug.Log("loading..");
    }

   // public void PlayGame(){
   //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   // }

   // public void PlayGameSenang(){
   //  SceneManager.LoadScene("SenangScene");
   // }

   // public void PlayGameTakut(){
   //  SceneManager.LoadScene("TakutScene");
   // }

   // public void PlayGameTerkejut(){
   //  SceneManager.LoadScene("TerkejutScene");
   // }

   // public void PlayGameMarah(){
   //  SceneManager.LoadScene("MarahScene");
   // }


   // public void PengaturanGame(){
   //    SceneManager.LoadScene("PengaturanMenu");
   // }

  

}
