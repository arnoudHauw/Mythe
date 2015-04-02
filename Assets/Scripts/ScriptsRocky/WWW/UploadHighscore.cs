using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UploadHighscore : MonoBehaviour
{
    public InputField nameInput;
    public GameObject score;
    string name = "dummyName3";
    const string uploadURL = "http://rockytempelaars.com/Mythe/Highscore/UploadScore.php";
    bool amiIuploading = false;
    public int scoreValue;

    // Use this for initialization
    /*
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("DontDestroyScore");
    }
    
    void OnEnable()
    {
        score = GameObject.FindGameObjectWithTag("DontDestroyScore");
    }
    */
    public void startScoreUpload()
    {
        if (!amiIuploading)
        {
            amiIuploading = true;
            Debug.Log(scoreValue);
            StartCoroutine(uploadScore());
        }
        
    }

    IEnumerator uploadScore()
    {
        //create form
        WWWForm form = new WWWForm();
        form.AddField("name", nameInput.text);
        form.AddField("score", scoreValue);

        WWW w = new WWW(uploadURL, form);
        yield return w;
        if (!string.IsNullOrEmpty(w.error))
        {
            print(w.error);
            amiIuploading = false;
        }
        else
        {
            print("Finished Uploading Score");
            gameObject.SetActive(false);
            amiIuploading = false;
        }
    }
}
