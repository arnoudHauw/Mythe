using UnityEngine;
using System.Collections;

public class CharacterSLide : MonoBehaviour
{
    public float slideSpeed = 0.05f;

    public Vector3 moveDistance;

    private Vector3 moveDirection;

    private bool movingLeft;

    private bool moving;

    // Use this for initialization
    void Start()
    {
        moveDirection = new Vector3(0, 0, 0);
        moveDistance = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(moving == true && this.transform.position.x != moveDistance.x)
        {
            Debug.Log("I RUN WHEN MOVING IS ON");
            if (this.transform.position.x > moveDistance.x && movingLeft == true)
            {
                this.transform.position += moveDirection;
            }
            else if (this.transform.position.x < moveDistance.x && movingLeft == false)
            {
                this.transform.position += moveDirection;
            }
            else
            {
                moving = false;
                this.transform.position = moveDistance;
                Debug.Log("TURNED OFF MOVING");
            }
        }
    }

    public void slideLeft()
    {
        if(moving != true && this.transform.position.x > -12)
        {
            movingLeft = true;
            moveDirection.x = -slideSpeed;
            moveDistance.x = this.transform.position.x - 3;
            moving = true;
        }
    }
    
    public void slideRight()
    {
        if(moving != true && this.transform.position.x < 12)
        {
            movingLeft = false;
            moveDirection.x = slideSpeed;
            moveDistance.x = this.transform.position.x + 3;
            moving = true;
        }
    }

    public int getSelectedChar()
    {
        if(this.transform.position.x == -12)
        {
            return 1;
        }
        else if (this.transform.position.x == -9)
        {
            return 2;
        }
        else if (this.transform.position.x == -6)
        {
            return 3;
        }
        else if (this.transform.position.x == -3)
        {
            return 4;
        }
        else if (this.transform.position.x == 0)
        {
            return 5;
        }
        else if (this.transform.position.x == 3)
        {
            return 6;
        }
        else if (this.transform.position.x == 6)
        {
            return 7;
        }
        else if (this.transform.position.x == 9)
        {
            return 8;
        }
        else if (this.transform.position.x == 12)
        {
            return 9;
        }
        else
        {
            return 666;
        }
        
        // Couldn't get that feckin' switch working.
    }

}
