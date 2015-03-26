using UnityEngine;
using System.Collections;

public class CharacterAnimationfix : MonoBehaviour
{

    Vector2 MoveDirection;

    void Update()
    {
        //MoveDirection = gameObject.GetComponent<testMovement>().moveDirection;
        MoveDirection.x = gameObject.GetComponent<PlayerMovement>().speed;
        if (MoveDirection.x <= 0)
        {
            this.transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (MoveDirection.x >= 0)
        {
            this.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
