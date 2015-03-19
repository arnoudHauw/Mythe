using UnityEngine;
using System.Collections;

public class DestroyChunk : MonoBehaviour {

    void Start()
    {
        StartCoroutine(DestroyTime(80.0f));
    }
    IEnumerator DestroyTime(float _destoryTime) 
    {
        _destoryTime -= Time.deltaTime;
        yield return new WaitForSeconds(_destoryTime);
        Destroy(gameObject);
	}
}
