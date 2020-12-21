using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    public static int timer_current=0;
    public int timer_public_limit;
    bool shoot=false;
    public GameObject bullet; 
    public AudioSource aus;


    void Update()
    {
        Time_Handler._timer(ref timer_current,ref timer_public_limit,ref shoot);

        //shoot the bullet when shoot is true 
        if(shoot)
        {
            Instantiate(bullet,transform.position,transform.rotation);
            aus.Play();
            shoot=false;
        }
    }
}