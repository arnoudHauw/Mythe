using UnityEngine;
using System.Collections;

public class DontDestroyScore : MonoBehaviour {

    public int score;

    public void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
}
