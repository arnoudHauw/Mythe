using UnityEngine;
using System.Collections;

public class CharacterSLide : MonoBehaviour
{
    public float slideSpeed = 0.05f;

    public Vector3 moveDistance;

    private Vector3 moveDirection;

    private bool movingLeft;

    private bool moving;

    public GameObject[] Allchars;
    
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
        if(moving != true && this.transform.position.x > -15)
        {
            movingLeft = true;
            moveDirection.x = -slideSpeed;
            moveDistance.x = this.transform.position.x - 3;
            moving = true;
        }
    }
    
    public void slideRight()
    {
        if(moving != true && this.transform.position.x < 15)
        {
            movingLeft = false;
            moveDirection.x = slideSpeed;
            moveDistance.x = this.transform.position.x + 3;
            moving = true;
        }
    }

    public GameObject getSelectedChar()
    {
        if (this.transform.position.x == -15)
        {
            return Allchars[10];
        }
        else if (this.transform.position.x == -12)
        {
            return Allchars[8];
        }
        else if (this.transform.position.x == -9)
        {
            return Allchars[7];
        }
        else if (this.transform.position.x == -6)
        {
            return Allchars[6];
        }
        else if (this.transform.position.x == -3)
        {
            return Allchars[5];
        }
        else if (this.transform.position.x == 0)
        {
            return Allchars[4];
        }
        else if (this.transform.position.x == 3)
        {
            return Allchars[3];
        }
        else if (this.transform.position.x == 6)
        {
            return Allchars[2];
        }
        else if (this.transform.position.x == 9)
        {
            return Allchars[1];
        }
        else if (this.transform.position.x == 12)
        {
            return Allchars[0];
        }
        else if(this.transform.position.x == 15)
        {
            return Allchars[9];
        }
        else
        {
            return null;
        }
        
        // Couldn't get that feckin' switch working.
    }

}
