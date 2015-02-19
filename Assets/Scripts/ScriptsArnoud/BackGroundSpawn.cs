﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum BackgroundType
{
    Stone,
    Forest
}
public class BackGroundSpawn : MonoBehaviour
{

    private float _spawnTime = 3;
    private float _spawnDelay = 1;

    public Transform spawn;

    public Vector3 spawnPosition;
    public GameObject[] stoneBackgrounds;
    public GameObject[] forestBackgrounds;



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
        backgroundType = BackgroundType.Forest;
        map.Add(BackgroundType.Stone, stoneBackgrounds);
        map.Add(BackgroundType.Forest, forestBackgrounds);

        InvokeRepeating("Spawn", _spawnDelay, _spawnTime);

        spawnPosition = spawn.position;
    }
   

    void Spawn()
    {
        Vector3 disSpawn = new Vector3(0, 0, 0);
        Vector3 spawnPos = spawnPosition + disSpawn;

        int objLenght = map[backgroundType].Length;
        GameObject obj = map[backgroundType][Random.Range(0, objLenght)];
        Instantiate(obj, spawnPos, transform.rotation);
    }

   
}
