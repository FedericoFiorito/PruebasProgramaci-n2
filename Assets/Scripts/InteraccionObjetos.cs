using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionObjetos : MonoBehaviour
{
    
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
        
    }
}
