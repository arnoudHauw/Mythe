using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    float speedcap = 25;
    float jumpForce = 200;
    public void horizotalMovement(float speed) 
    {


        if (speed > speedcap)
        {
            speed = speedcap;
        }
        if (speed < -speedcap)
        {
            speed = -speedcap;
        }
        //Debug.Log("speed = " + speed as string);
        //rigidbody2D.AddForce(new Vector2(speed/2, 0));
        transform.Translate(speed * Time.deltaTime /2,0,0);
    }
    public void jump() 
    {
        //Debug.Log("jump");
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jumpForce));
    }
}
