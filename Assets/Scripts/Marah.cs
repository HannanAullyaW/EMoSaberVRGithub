using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marah : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particle;
    private SpawnManager spawnManager;
    public int pointValue;
    // Start is called before the first frame update
    public float speed = 1.0f;
    void Start()
    {
         spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
        Destroy(gameObject, 6);
    }


    
}
