using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UploadHighscore : MonoBehaviour
{
    public InputField nameInput;
    GameObject score;
    string name = "dummyName3";
    const string uploadURL = "http://rockytempelaars.com/Mythe/Highscore/UploadScore.php";
    bool amiIuploading = false;

    // Use this for initialization
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("DontDestroyScore");
    }

    public void startScoreUpload()
    {
        if (!amiIuploading)
        {
            amiIuploading = true;
            StartCoroutine(uploadScore());
        }
        
    }

    IEnumerator uploadScore()
    {
        //create form
        WWWForm form = new WWWForm();
        form.AddField("name", nameInput.text);
        form.AddField("score", score.GetComponent<DontDestroyScore>().score);

        WWW w = new WWW(uploadURL, form);
        yield return w;
        if (!string.IsNullOrEmpty(w.error))
        {
            print(w.error);
        }
        else
        {
            print("Finished Uploading Score");
            Destroy(this.gameObject);
        }
    }
}
