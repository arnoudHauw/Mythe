using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour
{

    Touch touch1;
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
       touch1 = Input.touches[Input.touchCount - 1];
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
                if (touch.fingerId == touch1.fingerId)
                {
                    //Debug.Log("result if thisx - mousex" + (Input.mousePosition.x - transform.position.x) as string);
                    playerMovement.horizotalMovement((Input.mousePosition.x - transform.position.x));
                }
                if (touch.fingerId != touch1.fingerId && Time.time > cooldown)
                {
                    cooldown = Time.time + cooldowndelay;
                    playerMovement.jump();

                }
            }
        }
    }
}
