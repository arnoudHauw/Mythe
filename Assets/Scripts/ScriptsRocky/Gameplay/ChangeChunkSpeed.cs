using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeChunkSpeed : MonoBehaviour {

    //public List<GameObject> chunkList = new List<GameObject>();
    public GameObject[] chunkList;
    PlayerMovement playerMovement;
    public float chunkSpeed;
    public float speedIncrease;

    void Start() 
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    void Update() 
    {
        increaseSpeed();
    }

    void increaseSpeed() 
    {
        chunkList = GameObject.FindGameObjectsWithTag("Ground");
        chunkSpeed *= speedIncrease;
        playerMovement.speedcap += speedIncrease-1;
        foreach (GameObject chunk in chunkList)
        {
            chunk.GetComponent<BackGroundMovement>().speed *= speedIncrease;
        }

    }
}
