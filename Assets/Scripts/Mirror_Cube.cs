using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror_Cube : MonoBehaviour
{
    
    public Time_Handler Time_Handler;
    int timer=0;
    public ParticleSystem ps;
    bool for_once=false;

    void Update() 
    {
        if (Time_Handler.trap && !for_once)
        {
            gameObject.GetComponent<MeshRenderer>().enabled=false;
            ps.Play();
            for_once=true;
        } 
    }

    void FixedUpdate() 
    {
        if(timer<Time_Handler.posses.Length-1 && Time_Handler.mirror_turn && !Time_Handler.trap)
        {
            transform.position=Time_Handler.posses[timer];
            timer++;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("mirror_final"))
        {
            Time_Handler.mirror_final=true; 
        }

        if(other.CompareTag("trap"))
        {
            Time_Handler.trap=true; 
        } 
    } 
}
