using UnityEngine;
using System.Collections;

public class SlidePreview : MonoBehaviour
{
    public int turnSpeed = 2;
    public int turnDir;
    private Vector3 direction;
    private float cooldown;
    public int baseCooldown = 2;

    // Update is called once per frame
    void Update()
    {
        
       if(this.transform.rotation.z < -0.173f)
        {
            turnDir = turnSpeed;
        }
        else if (this.transform.rotation.z > 0.173f)
        {
            turnDir = -turnSpeed;
        }
       /*else if (Time.time > cooldown)
       {
           turnDir *= -1;
           cooldown = Time.time + baseCooldown + Random.Range(0, 3);
       }*/
        direction = new Vector3(0, 0,(Time.deltaTime * turnDir));
        Debug.Log(Time.deltaTime * turnDir);
        Debug.Log(direction);
        this.transform.Rotate(direction);
    }
}
