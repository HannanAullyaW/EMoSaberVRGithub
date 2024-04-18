using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 0){
            time -= Time.deltaTime;
        }
        else if(time < 0){
            time = 0;
        }
        int minutes = Mathf.FloorToInt(time/60);
        int seconds = Mathf.FloorToInt(time%60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
