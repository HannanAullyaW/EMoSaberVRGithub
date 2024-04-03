using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particleBenar;
    public GameObject particleSalah;
    public string labelBlock;
    public AudioClip soundSalah;
    public AudioClip soundBenar;
    public AudioSource playerAudioBenar;
    public AudioSource playerAudioSalah;


    private void OnTriggerEnter(Collider other)
    {
        
    if (other.gameObject.CompareTag(labelBlock))
    {
        Score.score += 10;
        Destroy(other.gameObject);
        GameObject hancur = Instantiate(particleBenar, other.transform.position, particleBenar.transform.rotation);
        playerAudioBenar.Play();
        Destroy(hancur,0.5f);
        Debug.Log("benar");
    }
    else if(!other.gameObject.CompareTag(labelBlock)){
        Score.score -= 5;
        Destroy(other.gameObject);
        GameObject hancur = Instantiate(particleSalah, other.transform.position, particleSalah.transform.rotation);
        playerAudioSalah.Play();
        Destroy(hancur,0.5f);
        Debug.Log("salah");
        
    }
    }

    
}
