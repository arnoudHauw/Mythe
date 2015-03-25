using UnityEngine;
using System.Collections;

public class BackGroundMovement : MonoBehaviour
{

    public float speed;
    private bool _mayISpawn = true;

    void Start()
    {
        speed = GameObject.FindGameObjectWithTag("ChunkController").GetComponent<ChangeChunkSpeed>().chunkSpeed;
    }

    void Update()
    {
        transform.Translate(Vector3.down * (speed * Time.deltaTime));
        if (this.transform.position.y > 0 && _mayISpawn == true)
        {
            _mayISpawn = false;
            GameObject.FindGameObjectWithTag("SpawnPoint").GetComponent<BackGroundSpawn>().Spawn();
        }
    }
}
