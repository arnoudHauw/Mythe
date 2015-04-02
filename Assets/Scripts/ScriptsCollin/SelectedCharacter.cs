using UnityEngine;
using System.Collections;

public class SelectedCharacter : MonoBehaviour
{

    public GameObject selChar;


    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this);
    }
}
