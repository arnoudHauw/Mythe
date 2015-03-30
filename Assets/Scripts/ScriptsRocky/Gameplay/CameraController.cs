using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    private float turnDir = 1;
    private Vector3 direction;
    private float turnSpeed = 1.5f;

    void Start() 
    {
        turnSpeed = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SlidePreview>().turnSpeed * 1.5f;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.acceleration.x > 0.15f)
        {
            turnDir = turnSpeed;
        }
        else if (Input.acceleration.x < -0.15f)
        {
            turnDir = -turnSpeed;
        }
        else 
        {
            turnDir = 0;
        }

        direction = new Vector3(0, 0, this.transform.rotation.y + (Time.deltaTime * turnDir));
        this.transform.Rotate(direction);

    }
}
