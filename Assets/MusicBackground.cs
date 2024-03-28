using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MusicBackground : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource musicBg;
    public AudioClip background;
    void Start()
    {
        musicBg.clip = background;
        musicBg.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
