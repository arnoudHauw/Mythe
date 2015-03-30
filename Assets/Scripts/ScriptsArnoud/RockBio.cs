using UnityEngine;
using System.Collections;

public class RockBio : MonoBehaviour
{
    public BackgroundType _type;
    public GameObject SpawnPoint;
    /*void Start()
    {
        StartCoroutine(FirstBio(25.0F));
    }*/
    /*IEnumerator FirstBio(float _bioTime)
    {
        _bioTime -= Time.deltaTime;
        yield return new WaitForSeconds(_bioTime);

        gameObject.GetComponent<BackGroundSpawn>().backgroundType = BackgroundType.Temple;
    }*/
    void Update()
    {
        if (this.gameObject.transform.position.y >= 0 && this.gameObject.transform.position.y <= 1)
        {
            SpawnPoint.GetComponent<BackGroundSpawn>().backgroundType = BackgroundType.Rock;
        }
    }
}
