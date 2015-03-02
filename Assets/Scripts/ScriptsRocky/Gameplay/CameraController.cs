using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.acceleration.x);
    }
}
