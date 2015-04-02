using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    const string scoreString = "Score ";
    public Text score;
    public int scoreValue = 0;
    public GameObject submitButton;

    void OnEnable()
    {
        scoreValue = 0;
        score.text = scoreString + scoreValue.ToString();
    }
   
    public void changeScore(int change)
    {
        scoreValue += change;
        score.text = scoreString + scoreValue.ToString();
    }

    void OnDisable()
    {
        submitButton.GetComponent<UploadHighscore>().scoreValue= scoreValue;
    }
}
