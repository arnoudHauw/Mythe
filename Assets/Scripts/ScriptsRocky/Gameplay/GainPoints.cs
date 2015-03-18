using UnityEngine;
using System.Collections;

public class GainPoints : MonoBehaviour {

    Score scoreScript;
	// Use this for initialization
	void Start () 
    {
	    scoreScript = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "ScoreBox")
        {
            scoreScript.changeScore(other.GetComponent<PointsScript>().score);
            Debug.Log("should change score");
        }
    }
}
