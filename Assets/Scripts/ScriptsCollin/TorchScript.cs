using UnityEngine;
using System.Collections;

public class TorchScript : MonoBehaviour
{

    public float torchHealth = 100F;
    public GameObject playerLight;
    private float lightPercentage;

    private float maxTorchSize;

    private float torchSwapVal;

    public float torchSwapRange = 5;

    public float torchDamnSpeed = 0.01f;

    
    // Use this for initialization
    void Start()
    {
        lightPercentage = playerLight.light.spotAngle / torchHealth;
        Debug.Log(lightPercentage);
        maxTorchSize = playerLight.light.spotAngle;

        playerLight.light.spotAngle += 1;
    }

    // Update is called once per frame
    void Update()
    {
        torchHealth -= Time.deltaTime;
        if(torchHealth < 0)
        {
            Destroy(this.gameObject);
        }
        
        if(playerLight.light.spotAngle > maxTorchSize)
        {
            torchSwapVal = -torchDamnSpeed;
        }
        else if (playerLight.light.spotAngle < maxTorchSize - torchSwapRange)
        {
            torchSwapVal = torchDamnSpeed;
        }

        Debug.Log(torchDamnSpeed);

        playerLight.light.spotAngle += torchSwapVal;

        maxTorchSize = lightPercentage * torchHealth;

    }

    void OnCollisionEnter2D(Collision2D other)
    {
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
