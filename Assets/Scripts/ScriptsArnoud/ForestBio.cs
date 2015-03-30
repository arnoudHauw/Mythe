using UnityEngine;
using System.Collections;

public class ForestBio : MonoBehaviour {

    public BackgroundType _type;
    public GameObject SpawnPoint;

    void Update()
    {
        if (this.gameObject.transform.position.y >= 0 && this.gameObject.transform.position.y <= 1)
        {
            SpawnPoint.GetComponent<BackGroundSpawn>().backgroundType = BackgroundType.Forest;
        }
    }
}
