using UnityEngine;
using System.Collections;

public class BackGroundMovement : MonoBehaviour
{

    public float speed;
    private bool _mayISpawn = true;

    void Update()
    {
        //UpdateSpeed();
        transform.Translate(Vector3.down * (speed * Time.deltaTime));
        if (this.transform.position.y > 0 && _mayISpawn == true)
        {
            _mayISpawn = false;
            GameObject.FindGameObjectWithTag("SpawnPoint").GetComponent<BackGroundSpawn>().Spawn();
        }
    }
    /*void UpdateSpeed()
    {
        _speed = _speed - 0.01f;
    }*/
}
