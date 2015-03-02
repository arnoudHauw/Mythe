﻿using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour
{
    int joyStickId = -1;
    //Touch touch1;
    PlayerMovement playerMovement;
    float cooldown = 0;
    float cooldowndelay = 1;
    void Start() 
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    public void click()
    {

        //stores the new touch into a variable so you can check the position in the update
        joyStickId = Input.touches[Input.touchCount - 1].fingerId;
       //touch1 = Input.touches[Input.touchCount - 1];
       Debug.Log("click");
    }

    // Update is called once per frame
    void Update()
    {
        //checks  if there are any touches
        if (Input.touchCount > 0)
        {
            //loop trough each touch to look for the touch we stored in click()  
            foreach (Touch touch in Input.touches)
            {
                if (touch.fingerId == joyStickId)
                {
                    //Debug.Log("result if thisx - mousex" + (Input.mousePosition.x - transform.position.x) as string);
                    playerMovement.horizotalMovement((touch.position.x - transform.position.x));
                    Debug.Log(touch.fingerId);
                    Debug.Log(touch.position);
                    
                }

                //checks if the touch is nog the joystick touch and fires the jump function
                if (touch.fingerId != joyStickId && Time.time > cooldown)
                {
                    Debug.Log(touch.fingerId);
                    Debug.Log(touch.position);
                    cooldown = Time.time + cooldowndelay;
                    playerMovement.jump();

                }

                //check of the joystick touch has ended and set the joystick id back to its basic value
                if (touch.fingerId == joyStickId && touch.phase == TouchPhase.Ended)
                {
                    joyStickId = -1;
                }
            }
        }
    }
}
