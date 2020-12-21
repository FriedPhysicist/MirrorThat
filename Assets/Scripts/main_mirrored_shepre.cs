using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_mirrored_shepre : MonoBehaviour
{

    void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("mirrored_cube"))
        { 
            Destroy(gameObject,0f);
        }

        if(other.CompareTag("floor"))
        { 
            Destroy(gameObject,0f);
        }
    }
}
