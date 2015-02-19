using UnityEngine;
using System.Collections;

public class LoseObjectScript : MonoBehaviour
{

    public GameObject mainCamera;
    private Vector2 direction;
    public float slideMultiplier;

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(mainCamera.transform.rotation.z * slideMultiplier, this.rigidbody2D.velocity.y);

        this.rigidbody2D.velocity = direction;
    }
}
