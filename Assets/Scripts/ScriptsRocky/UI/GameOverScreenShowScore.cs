using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScreenShowScore : MonoBehaviour {

    public Text scoreText;
    string baseText = "your score ";
    float score = 20;
	// Use this for initialization
	void Start () 
    {
        score = GameObject.FindGameObjectWithTag("DontDestroyScore").GetComponent<DontDestroyScore>().score;
        scoreText.text = baseText + score.ToString();
	}
}
