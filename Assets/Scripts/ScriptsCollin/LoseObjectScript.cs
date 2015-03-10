using UnityEngine;
using System.Collections;

public class LoseObjectScript : MonoBehaviour
{

    public Camera mainCamera = Camera.main;
    private Vector2 direction;
    public float slideMultiplier;

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(mainCamera.transform.rotation.z * slideMultiplier, this.GetComponent<Rigidbody2D>().velocity.y);

        this.GetComponent<Rigidbody2D>().velocity = direction;
    }
}
