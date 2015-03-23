using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour
{

    public void RestartClick()
    {
        Application.LoadLevel(1);
    }
}
