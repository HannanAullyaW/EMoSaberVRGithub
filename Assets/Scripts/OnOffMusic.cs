using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject musicOff;
    public GameObject musicOn;
  
    
    public void MusicOn(){
        BackgroundMusic.bgMusic.GetComponent<AudioSource>().Play();
        musicOn.SetActive(true);
        musicOff.SetActive(false);
    }
    public void MusicOff(){
        BackgroundMusic.bgMusic.GetComponent<AudioSource>().Pause();
        musicOn.SetActive(false);
        musicOff.SetActive(true);
    }
}
