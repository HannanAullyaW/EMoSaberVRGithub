using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[ ] blockPrefabs; 
    public TextMeshProUGUI scoreText;
    private int score;
    public float spawnPosZ = -10f;
    // public float spawnRangeX = 1;
    private float spawnInterval = 1f;
    private float startDelay = 1;
    void Start()
    {

        InvokeRepeating("SpawnRandomBlock", startDelay, spawnInterval);
        score = 0;
        // UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            SpawnRandomBlock();
        }
    }

    void SpawnRandomBlock(){
        int blockIndex = Random.Range(0, blockPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(2, 6), 0, spawnPosZ);
            Instantiate(blockPrefabs[blockIndex], spawnPos, blockPrefabs[blockIndex].transform.rotation);
            
    }

    public void UpdateScore(int scoreToAdd){
        
        score += scoreToAdd;
        scoreText.text = "Score : " + score;

    }
    
    }
