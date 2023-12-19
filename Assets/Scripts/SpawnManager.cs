using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[ ] blockPrefabs; 
    public float spawnPosZ = -3f;
    private float spawnRangeX= 2;
    private float spawnInterval = 2f;
    private float startDelay = 3;
    void Start()
    {
        InvokeRepeating("SpawnRandomBlock", startDelay, spawnInterval);
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
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(blockPrefabs[blockIndex], spawnPos, blockPrefabs[blockIndex].transform.rotation);
    }
}
