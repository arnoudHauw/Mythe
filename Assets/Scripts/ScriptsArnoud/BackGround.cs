using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour
{
    public BackgroundType _type;
    void Start()
    {
        StartCoroutine(FirstBio(25.0F));
    }
    IEnumerator FirstBio(float _bioTime)
    {
        _bioTime -= Time.deltaTime;
        yield return new WaitForSeconds(_bioTime);

        gameObject.GetComponent<BackGroundSpawn>().backgroundType = BackgroundType.Temple;
    }
}
