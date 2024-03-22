using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marah : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    if (other.gameObject.CompareTag("Marah"))
    {
        Destroy(other.gameObject);
        GameObject hancur = Instantiate(particle, transform.position, particle.transform.rotation);
        Destroy(hancur,2f);
        Debug.Log("benar");
    }
    else if(!other.gameObject.CompareTag("Marah")){
        Destroy(other.gameObject);
        GameObject hancur = Instantiate(particle, transform.position, particle.transform.rotation);
        Destroy(hancur,2f);
        Debug.Log("salah");
    }
    {    
       

    }

    }

    
}
