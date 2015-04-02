using UnityEngine;
using System.Collections;

public class testMovement : MonoBehaviour
{
    float moveSpeed = 7;

    public float slideMultiplier = 50;
    
    public Vector2 moveDirection;
    //  + (mainCamera.transform.rotation.z * slideMultiplier)
    public Camera mainCamera;
    public GameObject Char;
    public AudioClip WalkClip;
    public AudioClip JumpClip;


    private const string ISWALKING = "IsWalking";
    private const string ISJUMPING = "IsJumping";

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        moveDirection = new Vector2(Input.GetAxis("Horizontal") * moveSpeed + (mainCamera.transform.rotation.z * slideMultiplier), this.GetComponent<Rigidbody2D>().velocity.y);
        

        if (moveDirection.x != 0.0f)
        {
            Char.GetComponent<Animator>().SetBool(ISWALKING, true);
        }
        else
        {
            Char.GetComponent<Animator>().SetBool(ISWALKING, false);
            GetComponent<AudioSource>().clip = WalkClip;
            GetComponent<AudioSource>().loop = true;
            GetComponent<AudioSource>().Play();
        }

        this.GetComponent<Rigidbody2D>().velocity = moveDirection;
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        
        if(coll.gameObject.tag == "Ground" || coll.gameObject.tag == "Destroyable")
        {
            
            if(Input.GetButton("Jump"))
            {
                moveDirection.y = 5;
                this.GetComponent<Rigidbody2D>().velocity = moveDirection;
                Char.GetComponent<Animator>().SetTrigger(ISJUMPING);
                GetComponent<AudioSource>().clip = JumpClip;
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
