using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour
{
    public BackgroundType _type;
    void Start()
    {
        Debug.Log(Application.unityVersion);
        StartCoroutine(NextBio(50.0F));
    }
    IEnumerator NextBio(float _bioTime)
    {
        _bioTime -= Time.deltaTime;
        yield return new WaitForSeconds(_bioTime);
        
        gameObject.GetComponent<BackGroundSpawn>().backgroundType = BackgroundType.Stone;

        Debug.Log(_type);
    }
}
