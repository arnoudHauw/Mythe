using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour {

    public void StartGame()
    {
        if (GameObject.Find("DontDestroyScore") != null)
        {
            GameObject.FindGameObjectWithTag("DontDestroyScore").GetComponent<DontDestroyScore>().score = 0;
        }
        Application.LoadLevel(1);
    }
}
