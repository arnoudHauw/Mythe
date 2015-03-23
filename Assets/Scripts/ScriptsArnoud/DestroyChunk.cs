using UnityEngine;
using System.Collections;

public class DestroyChunk : MonoBehaviour {

    public int DeSpawn;
    void Update() 
    {
        if(this.transform.position.y > DeSpawn)
        {
            Destroy(this.gameObject);
        }
	}
}
