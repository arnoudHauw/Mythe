using UnityEngine;
using System.Collections;

public class OnCharacerSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        GameObject.FindGameObjectWithTag("FlameBar").GetComponent<FlameBarController>().torch = GetComponent<TorchScript>();
        GameObject.FindGameObjectWithTag("JoyStick").GetComponent<MovementController>().playerMovement = GetComponent<PlayerMovement>();
        GameObject.FindGameObjectWithTag("PlayerLight").GetComponent<FollowerScript>().target = this.gameObject;
        GetComponent<TorchScript>().playerLight = GameObject.FindGameObjectWithTag("PlayerLight");
	}
}
