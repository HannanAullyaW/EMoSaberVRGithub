using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject particle;
    // Start is called before the first frame update
    public float speed = 1.0f;
    void Start()
    {
        // particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * -speed * Time.deltaTime);
        Destroy(gameObject,6);
    }

    //     private void OnTriggerEnter(Collider other)
    // {

    // }

    private void OnCollisionEnter(Collision other) 
    {
        
        Destroy(gameObject);
        GameObject hancur = Instantiate(particle, transform.position, particle.transform.rotation);
        Destroy(hancur,0.5f);
        Debug.Log("Hnacr");
        
        
    }

}
