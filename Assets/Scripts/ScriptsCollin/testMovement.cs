using UnityEngine;
using System.Collections;

public class testMovement : MonoBehaviour
{
    float moveSpeed = 7;

    public float slideMultiplier = 50;

    Vector2 moveDirection;
    //  + (mainCamera.transform.rotation.z * slideMultiplier) 
    public GameObject mainCamera;
    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector2(Input.GetAxis("Horizontal") * moveSpeed + (mainCamera.transform.rotation.z * slideMultiplier), this.rigidbody2D.velocity.y);

        this.rigidbody2D.velocity = moveDirection;
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        
        if(coll.gameObject.tag == "Ground" || coll.gameObject.tag == "Destroyable")
        {
            
            if(Input.GetButton("Jump"))
            {
                moveDirection.y = 5;
                this.rigidbody2D.velocity = moveDirection;
            }
        }
    }
}
