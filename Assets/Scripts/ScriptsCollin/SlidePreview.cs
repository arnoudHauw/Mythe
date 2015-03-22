using UnityEngine;
using System.Collections;

public class SlidePreview : MonoBehaviour
{
    public int turnDir = 2;
    private Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("localrotation " + this.transform.localRotation.z + " world rotation " + transform.rotation.z);
        if(this.transform.rotation.z < -0.173f)
        {
            turnDir *= -1;
        }
        else if (this.transform.rotation.z > 0.173f)
        {
            turnDir *= -1;
        }

        direction = new Vector3(0, 0, this.transform.rotation.y + (Time.deltaTime * turnDir));
        this.transform.Rotate(direction);
    }
}
