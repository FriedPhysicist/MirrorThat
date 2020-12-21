using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Time_Handler : MonoBehaviour
{
    
    public bool mirror_turn=false;
    public bool mirror_final=false;
    public bool trap=false;
    public Vector3[] posses= new Vector3[0];
    public int poss_number=0;
    public Canvas lose_canvas;
    public Canvas win_canvas;


    void Start()
    {
        win_canvas.enabled=false;
        lose_canvas.enabled=false;            
    }


    void Update() 
    {
        if(trap)
        {
            lose_canvas.enabled=true;            
            Destroy(GameObject.FindGameObjectWithTag("mirrored_shepre"),0f); 
        }

        if(mirror_final)
        {
            win_canvas.enabled=true;
        }
    }

    public void stores_(Vector3 current_pos)
    {
        posses[poss_number]=current_pos;
        poss_number++;
        System.Array.Resize(ref posses, poss_number+1);
    } 

    //this is timer, increase timer_current every fixedupdate, when timer_current
    //equals to timer public, timer_current will be zero and bool_ will be reverse of current 
    public static void _timer(ref int timer_current,ref int timer_public,ref bool bool_)
    {
        timer_current++;

        if(timer_current>=timer_public)
        {
            bool_=!bool_; 
            timer_current=0;
        } 
    } 
}

