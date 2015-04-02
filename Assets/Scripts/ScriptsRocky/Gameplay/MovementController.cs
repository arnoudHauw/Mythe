using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour
{
    public int joyStickId = -1;
    //Touch touch1;
    public PlayerMovement playerMovement;
    public GameObject mainCamera;
    public GameObject Char;
    float cooldown = 0;
    float cooldowndelay = 1;
    private const string ISWALKING = "IsWalking";
    /*void Start() 
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }*/

    void OnEnable()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
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
                //checks if the touch is not the joystick touch and fires the jump function
                if (touch.fingerId != joyStickId && Time.time > cooldown)
                {
                    cooldown = Time.time + cooldowndelay;
                    playerMovement.jump();
                }
                else if (touch.fingerId == joyStickId)
                {
                    //Debug.Log("result if thisx - mousex" + (Input.mousePosition.x - transform.position.x) as string);
                    if (mainCamera.transform.rotation.z < 0.13f && mainCamera.transform.rotation.z > -0.13f)
                    {
                        playerMovement.horizotalMovement((touch.position.x - transform.position.x));
                    }

                    //check of the joystick touch has ended and set the joystick id back to its basic value
                    if (touch.phase == TouchPhase.Ended)
                    {
                        joyStickId = -1;
                        Char.GetComponent<Animator>().SetBool(ISWALKING, false);
                    }
                    
                }

                

                
            }
        }
    }
}
