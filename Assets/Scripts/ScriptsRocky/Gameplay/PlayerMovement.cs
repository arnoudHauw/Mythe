using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    float speedcap = 25;
    float jumpForce = 200;

    public void horizotalMovement(float speed) 
    {
        //checks if the speed is over the maximum and when it is sets it to the maximum speed
        if (speed > speedcap)
        {
            speed = speedcap;
        }
        else if (speed < -speedcap)
        {
            speed = -speedcap;
        }

        //applies movement
        transform.Translate(speed * Time.deltaTime /2,0,0);
    }

    public void jump() 
    {
        rigidbody2D.AddForce(new Vector2(0,jumpForce));
    }
}
