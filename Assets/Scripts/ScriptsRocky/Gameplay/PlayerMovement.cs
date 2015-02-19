using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    float speedcap = 25;
    float jumpForce = 200;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void horizotalMovement(float speed) 
    {

        
        if(speed > 50)
        {
            speed = speedcap;
        }
        if(speed < -50)
        {
            speed = -speedcap;
        }
        Debug.Log("speed = " + speed as string);
        rigidbody2D.AddForce(new Vector2(speed/2, 0));
       // transform.Translate(speed * Time.deltaTime,0,0);
    }
    public void jump() 
    {
        Debug.Log("jump");
        rigidbody2D.AddForce(new Vector2(0,jumpForce));
    }
}
