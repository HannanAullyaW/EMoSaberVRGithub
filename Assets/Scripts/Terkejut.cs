using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terkejut : MonoBehaviour
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
        
    if (other.gameObject.CompareTag("Terkejut"))
    {
        Destroy(other.gameObject);
        GameObject hancur = Instantiate(particle, transform.position, particle.transform.rotation);
        Destroy(hancur,0.5f);
        Debug.Log("benar");
    }
    else {
        Destroy(other.gameObject);

    }

    }

    
}
