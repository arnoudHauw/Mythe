using UnityEngine;
using System.Collections;

public class DeadScript : MonoBehaviour {

	
	void OnTriggerEnter2D (Collider2D player) {
        if (player == true && player.tag == "Player")
            Application.LoadLevel(0);
	}
}
