using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeChunkSpeed : MonoBehaviour {

    //public List<GameObject> chunkList = new List<GameObject>();
    public GameObject[] chunkList;
    public float chunkSpeed;
    public float speedIncrease;

    void Update() 
    {
        increaseSpeed();
    }

    void increaseSpeed() 
    {
        chunkList = GameObject.FindGameObjectsWithTag("Ground");
        chunkSpeed *= speedIncrease;
        foreach (GameObject chunk in chunkList)
        {
            chunk.GetComponent<BackGroundMovement>().speed *= speedIncrease;
        }

    }
}
