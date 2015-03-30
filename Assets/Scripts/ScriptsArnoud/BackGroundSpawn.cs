using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum BackgroundType
{
    Snow,
    Temple,
    Forest
}
public class BackGroundSpawn : MonoBehaviour
{

    public Transform spawn;

    public Vector3 spawnPosition;
    public GameObject[] templeBackgrounds;
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
        map.Add(BackgroundType.Temple, templeBackgrounds);
        map.Add(BackgroundType.Forest, forestBackgrounds);
        spawnPosition = spawn.position;
    }


    public void Spawn()
    {
        Vector3 disSpawn = new Vector3(3, 0, 0);
        Vector3 spawnPos = spawnPosition + disSpawn;

        int objLenght = map[backgroundType].Length;
        GameObject obj = map[backgroundType][Random.Range(0, objLenght)];
        Instantiate(obj, spawnPos, transform.rotation);
    }


}
