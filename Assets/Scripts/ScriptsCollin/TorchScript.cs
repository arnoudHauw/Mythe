using UnityEngine;
using System.Collections;

public class TorchScript : MonoBehaviour
{

    public float torchHealth = 100F;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        torchHealth -= Time.deltaTime;
        if(torchHealth < 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if(other.gameObject.tag == "Destroyable")
        {
            torchHealth -= 2.5F;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "Barrel")
        {
            torchHealth = 20;
            Debug.Log("Health Refilled");
        }

    }
}
