using UnityEngine;
using System.Collections;

public class DeadScript : MonoBehaviour {

	
	void OnTriggerEnter2D (Collider2D player) {
        if (player == true && player.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("DontDestroyScore").GetComponent<DontDestroyScore>().score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>().scoreValue;
            Application.LoadLevel(2);
        }
	}
}
