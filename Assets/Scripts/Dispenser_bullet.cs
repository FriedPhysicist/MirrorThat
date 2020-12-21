using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser_bullet : MonoBehaviour
{
    public Rigidbody rigidbody;

    void Update() 
    { 
        Destroy(gameObject,5f);
    }

    void FixedUpdate()
    {
        rigidbody.AddRelativeForce(Vector3.up*20f);
    }

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