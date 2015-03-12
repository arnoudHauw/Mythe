﻿using UnityEngine;
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
        lightPercentage = playerLight.GetComponent<Light>().spotAngle / torchHealth;
        Debug.Log(lightPercentage);
        maxTorchSize = playerLight.GetComponent<Light>().spotAngle;

        playerLight.GetComponent<Light>().spotAngle += 1;
    }

    // Update is called once per frame
    void Update()
    {
        torchHealth -= Time.deltaTime;
        if(torchHealth < 0)
        {
            Destroy(this.gameObject);
        }
        
        if(playerLight.GetComponent<Light>().spotAngle > maxTorchSize)
        {
            torchSwapVal = -torchDamnSpeed;
        }
        else if (playerLight.GetComponent<Light>().spotAngle < maxTorchSize - torchSwapRange)
        {
            torchSwapVal = torchDamnSpeed;
        }

        Debug.Log(torchDamnSpeed);

        playerLight.GetComponent<Light>().spotAngle += torchSwapVal;

        maxTorchSize = lightPercentage * torchHealth;

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Destroyable")
        {
            torchHealth -= 10F;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "Barrel")
        {
            torchHealth = 100;
            Debug.Log("Health Refilled");
        }

    }
}
