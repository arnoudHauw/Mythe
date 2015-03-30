using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speedcap = 25;
    float jumpForce = 300;
    public float speed;
    public GameObject Character;
    public AudioClip WalkClip;
    public AudioClip JumpClip;


    private const string ISWALKING = "IsWalking";
    private const string ISJUMPING = "IsJumping";

    public void horizotalMovement(float speedIn) 
    {
        //checks if the speed is over the maximum and when it is sets it to the maximum speed
        if (speedIn > speedcap)
        {
            speedIn = speedcap;
        }
        else if (speedIn < -speedcap)
        {
            speedIn = -speedcap;
        }
        speed = speedIn;
        //applies movement
        transform.Translate(speed * Time.deltaTime /2,0,0);
    }

    public void jump() 
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jumpForce));
        Character.GetComponent<Animator>().SetTrigger(ISJUMPING);
        GetComponent<AudioSource>().clip = JumpClip;
        GetComponent<AudioSource>().Play();
    }
}
