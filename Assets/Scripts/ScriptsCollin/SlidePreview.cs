using UnityEngine;
using System.Collections;

public class SlidePreview : MonoBehaviour
{
    private int turnDir = 1;
    private Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        if(this.transform.rotation.z > 0.03)
        {
            turnDir = -1;
        }
        else if(this.transform.rotation.z < -0.03)
        {
            turnDir = 1;
        }

        direction = new Vector3(0, 0, this.transform.rotation.y + (Time.deltaTime / 2 * turnDir));
        this.transform.Rotate(direction);
    }
}
