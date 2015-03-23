using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum BackgroundType
{
    Snow,
    Stone,
    Forest
}
public class BackGroundSpawn : MonoBehaviour
{

    private float _spawnTime = 14.0f;
    public float _spawnDelay = 6.0f;

    public Transform spawn;

    public Vector3 spawnPosition;
    public GameObject[] stoneBackgrounds;
    public GameObject[] forestBackgrounds;
    public GameObject[] SnowBackgrounds;



    private Dictionary<BackgroundType, GameObject[]> map = new Dictionary<BackgroundType, GameObject[]>();
    public BackgroundType _backgroundType;

    public BackgroundType backgroundType
    {
        get
        {
            return _backgroundType;
        }
        set
        {
            _backgroundType = value;
        }
    }

    void Start()
    {
        backgroundType = BackgroundType.Snow;
        map.Add(BackgroundType.Snow, SnowBackgrounds);
        map.Add(BackgroundType.Stone, stoneBackgrounds);
        map.Add(BackgroundType.Forest, forestBackgrounds);

        InvokeRepeating("Spawn", _spawnDelay, _spawnTime);

        spawnPosition = spawn.position;
    }
   

    void Spawn()
    {
        Vector3 disSpawn = new Vector3(3, 0, 0);
        Vector3 spawnPos = spawnPosition + disSpawn;

        int objLenght = map[backgroundType].Length;
        GameObject obj = map[backgroundType][Random.Range(0, objLenght)];
        Instantiate(obj, spawnPos, transform.rotation);
    }

   
}
