using UnityEngine;
using System.Collections;

public class GameOverAnimation : MonoBehaviour {

    

    void OnEnable() 
    {
        GetComponent<Animator>().Play(0, -1, (0) / 100);
    }
            
      
}
