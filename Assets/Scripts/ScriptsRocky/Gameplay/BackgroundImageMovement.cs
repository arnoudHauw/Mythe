using UnityEngine;
using System.Collections;

public class BackgroundImageMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(0,0.003f,0);
	}
}
