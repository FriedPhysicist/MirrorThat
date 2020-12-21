using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    GameObject beam;
    public int timer_limit;
    int timer_limit_script;
    public static int timer_current;
    bool bool_=false;
    public AudioSource audioSource;


    void Start()
    {
        beam=transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        timer_limit_script= bool_ ? timer_limit/4:timer_limit;


        if (bool_)
        {
            audioSource.Play();
            beam.transform.localPosition=new Vector3(0,4f,0);
            beam.transform.localScale=new Vector3(0.5f,4f,0.5f);

        } 

        if (!bool_)
        {
            beam.transform.localPosition=new Vector3(0.01f,0.01f,0.1f);
            beam.transform.localScale=new Vector3(0.01f,0.01f,0.1f);
        } 
    }

    void FixedUpdate()
    {
        Time_Handler._timer(ref timer_current,ref timer_limit_script, ref bool_);
    }
}
