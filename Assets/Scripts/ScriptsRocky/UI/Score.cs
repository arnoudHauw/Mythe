using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text score;
    int _score = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        changeScore(1);
    }

    void changeScore(int change)
    {
        _score += change;
        score.text = "Score " + _score.ToString();
    }
}
