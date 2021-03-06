﻿using UnityEngine;
using System.Collections;

public class TorchScript : MonoBehaviour
{

    public float torchHealth = 100F;
    public float torchDepletionSpeed;
    public GameObject playerLight;
    private float lightPercentage;

    private float maxTorchSize;

    private float torchSwapVal;

    public float torchSwapRange = 50;

    public float torchDamnSpeed = 1f;

    
    // Use this for initialization
    void Start()
    {
        lightPercentage = playerLight.GetComponent<Light>().intensity / torchHealth;
        //Debug.Log(lightPercentage);
        maxTorchSize = playerLight.GetComponent<Light>().intensity;

        playerLight.GetComponent<Light>().intensity += 1;
    }

    // Update is called once per frame
    void Update()
    {
        torchHealth -= Time.deltaTime * torchDepletionSpeed;
        if(torchHealth < 0)
        {
            GameObject.FindGameObjectWithTag("DontDestroyScore").GetComponent<DontDestroyScore>().score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>().scoreValue;
            Application.LoadLevel(2);
            //Destroy(this.gameObject);
        }
        if (8f / 100f * torchHealth>2)
        {
            playerLight.GetComponent<Light>().intensity = 8f/100f*torchHealth;
        }
        else
        {
            playerLight.GetComponent<Light>().intensity = 2;
        }
        
        /*
        if(playerLight.GetComponent<Light>().intensity > maxTorchSize && playerLight.GetComponent<Light>().intensity > 2)
        {
            torchSwapVal = -torchDamnSpeed;
        }
        else if (playerLight.GetComponent<Light>().intensity < maxTorchSize - torchSwapRange && playerLight.GetComponent<Light>().intensity > 2)
        {
            torchSwapVal = torchDamnSpeed;
        }

       // Debug.Log(torchDamnSpeed);

        playerLight.GetComponent<Light>().intensity += torchSwapVal;

        maxTorchSize = lightPercentage * torchHealth;
        */

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Destroyable")
        {
            torchHealth -= 10F;
            other.GetComponent<Animator>().SetTrigger("StartAnim");
            //Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "Barrel")
        {
            torchHealth = 100;
           // Debug.Log("Health Refilled");
        }

    }
}
