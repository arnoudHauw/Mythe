using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    const string scoreString = "Score ";
    public Text score;
    public int scoreValue = 0;
    // Use this for initialization
    void Start()
    {

    }

   
    public void changeScore(int change)
    {
        scoreValue += change;
        score.text = scoreString + scoreValue.ToString();
    }
}
