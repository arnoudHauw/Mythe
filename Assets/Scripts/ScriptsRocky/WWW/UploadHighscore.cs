using UnityEngine;
using System.Collections;

public class UploadHighscore : MonoBehaviour
{

    Score score;
    const string scoreString = "Score";
    string name = "dummyName3";
    const string uploadURL = "http://localhost/Mythe/UploadScore.php";

    // Use this for initialization
    void Start()
    {
        score = GameObject.FindGameObjectWithTag(scoreString).GetComponent<Score>();
        //temporary on start
        StartCoroutine(uploadScore());
    }

    public void startScoreUpload()
    {
        StartCoroutine(uploadScore());
    }

    IEnumerator uploadScore()
    {
        //create form
        WWWForm form = new WWWForm();
        form.AddField("name", name);
        form.AddField("score", score.scoreValue);

        WWW w = new WWW(uploadURL, form);
        yield return w;
        if (!string.IsNullOrEmpty(w.error))
        {
            print(w.error);
        }
        else
        {
            print("Finished Uploading Score");
        }
    }
}
