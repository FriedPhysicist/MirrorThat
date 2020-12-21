using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main_Cube : MonoBehaviour
{
    
    public Rigidbody rb;
    public float speed;
    float input_z;
    float input_y;
    public Time_Handler Time_Handler; 
    public ParticleSystem ps; 
    bool for_once=false;
    public GameObject mirrored_shepre;
    
    void Start()
    {
        
    }

    void Update()
    {

        input_y=Input.GetAxis("Vertical");
        input_z=Input.GetAxis("Horizontal");

        rb.isKinematic= Time_Handler.trap ? true:false;

        if (Time_Handler.trap && !for_once)
        {
            gameObject.GetComponent<MeshRenderer>().enabled=false;
            ps.Play();
            for_once=true;
        } 
    }


    void FixedUpdate()
    {
        if(!Time_Handler.mirror_turn && !Time_Handler.trap)
        {
            rb.velocity=new Vector3(rb.velocity.x,input_y*speed,-input_z*speed);
        }

        Time_Handler.stores_(new Vector3(-transform.position.x,transform.position.y,transform.position.z));

        if(rb.velocity.z!=0 || rb.velocity.y!=0) 
        {
            Instantiate(mirrored_shepre,new Vector3(-transform.position.x,transform.position.y,transform.position.z),Quaternion.identity); 
        }
    }

    bool zero_once_timer=false;
    void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("main_final") && !zero_once_timer)
        {
            Debug.Log("some");
            Time_Handler.mirror_turn=true; 
            Dispenser.timer_current=0;
            Laser.timer_current=0;
            rb.isKinematic=true;
            zero_once_timer=true;
        }

        if(other.CompareTag("trap"))
        {
            Time_Handler.trap=true; 
        }
        
    }

} 
