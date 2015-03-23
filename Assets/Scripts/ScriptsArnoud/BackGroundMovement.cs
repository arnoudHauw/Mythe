using UnityEngine;
using System.Collections;

public class BackGroundMovement : MonoBehaviour {

    public float speed = -1.5f;
    //public ChangeChunkSpeed controller;

    void Start() 
    {

        //controller = GameObject.FindGameObjectWithTag("ChunkController").GetComponent<ChangeChunkSpeed>();
        //speed = controller.chunkSpeed;
    }

	void Update () 
    {
        //UpdateSpeed();
        transform.Translate(Vector3.down * (speed * Time.deltaTime));
	}
    /*void UpdateSpeed()
    {
        _speed = _speed - 0.01f;
    }*/
}
