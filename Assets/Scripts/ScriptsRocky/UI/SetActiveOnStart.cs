using UnityEngine;
using System.Collections;

public class SetActiveOnStart : MonoBehaviour {

    public int levelInt;


    public void setActive()
    {
        gameObject.SetActive(true);
    }

    public void setNonActive() 
    {
        gameObject.SetActive(false);
    }
}
