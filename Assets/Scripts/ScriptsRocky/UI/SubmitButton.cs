using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SubmitButton : MonoBehaviour {

    public InputField nameInput;
    public GameObject score;
	// Use this for initialization
    /*
	void Start () 
    {
        score = GameObject.FindGameObjectWithTag("DontDestroyScore");
	}
   
    void OnEnable()
    {
        score = GameObject.FindGameObjectWithTag("DontDestroyScore");
    }
     */
    public void Click()
    {
        Debug.Log("name : " + nameInput.text);
        Debug.Log(score.GetComponent<DontDestroyScore>().score);
    }
}
