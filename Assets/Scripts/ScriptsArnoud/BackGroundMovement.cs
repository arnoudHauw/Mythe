using UnityEngine;
using System.Collections;

public class BackGroundMovement : MonoBehaviour {

    public float _speed = -1.5f;

	void Update () 
    {
        //UpdateSpeed();
        transform.Translate(Vector3.down * (_speed * Time.deltaTime));
	}
    /*void UpdateSpeed()
    {
        _speed = _speed - 0.01f;
    }*/
}
