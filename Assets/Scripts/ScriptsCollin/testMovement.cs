using UnityEngine;
using System.Collections;

public class testMovement : MonoBehaviour
{
    float moveSpeed = 7;

    public float slideMultiplier = 50;
    
    public Vector2 moveDirection;
    //  + (mainCamera.transform.rotation.z * slideMultiplier)
    public GameObject mainCamera;
    public GameObject Char;
    // Update is called once per frame

    private const string ISWALKING = "IsWalking";
    private const string ISJUMPING = "IsJumping";

    void Update()
    {
        moveDirection = new Vector2(Input.GetAxis("Horizontal") * moveSpeed + (mainCamera.transform.rotation.z * slideMultiplier), this.GetComponent<Rigidbody2D>().velocity.y);

        if (moveDirection.y <= 0.5f)
        {
            Char.GetComponent<Animator>().SetBool(ISWALKING, true);
            //Char.GetComponent<Animator>().SetTrigger(ISJUMPING);
        }
        else
        {
            Char.GetComponent<Animator>().SetBool(ISWALKING, false);
        }

        this.GetComponent<Rigidbody2D>().velocity = moveDirection;
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        
        if(coll.gameObject.tag == "Ground" || coll.gameObject.tag == "Destroyable")
        {
            
            
            if(Input.GetButtonDown("Jump"))
            {
                moveDirection.y = 5;
                this.GetComponent<Rigidbody2D>().velocity = moveDirection;
                Char.GetComponent<Animator>().SetTrigger(ISJUMPING);
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
