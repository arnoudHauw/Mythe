using UnityEngine;
using System.Collections;

public class BackGroundMovement : MonoBehaviour {

	void Update () {
        transform.Translate(Vector3.down * (-2 * Time.deltaTime));
	}
}
