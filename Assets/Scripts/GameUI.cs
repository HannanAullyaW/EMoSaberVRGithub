using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{

   public void PlayGame(string namaScene){
    BackgroundMusic.bgMusic.GetComponent<AudioSource>().Stop();
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
      Debug.Log("Keluar");
      Application.Quit();
   }
    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
        Debug.Log("loading..");
    }
  

}
