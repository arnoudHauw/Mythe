using UnityEngine;
using System.Collections;

public class BackGroundMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * (2 * Time.deltaTime));
	}
}
