using UnityEngine;
using System.Collections;
using System.Linq;

public class DontDestroyCanvas : MonoBehaviour {

    public void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

    void OnLevelWasLoaded(int level)
    {
        foreach (Transform item in this.transform)
        {
            SetActiveOnStart tempScript = item.GetComponent<SetActiveOnStart>();
            if (level == tempScript.levelInt)
            {
                tempScript.setActive();
            }
            else 
            {
                tempScript.setNonActive();
            }
        }
    }
}
