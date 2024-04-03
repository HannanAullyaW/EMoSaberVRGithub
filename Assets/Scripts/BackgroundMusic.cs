using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public static BackgroundMusic bgMusic;
    void Awake() {
        if (bgMusic != null)
        {
            Destroy(gameObject);
        }else{
            bgMusic= this;
            DontDestroyOnLoad(gameObject);
        } 
    }
}
