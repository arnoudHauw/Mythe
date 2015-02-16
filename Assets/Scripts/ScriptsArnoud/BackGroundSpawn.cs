using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum BackgroundType
{
    Stone,
    Forest
}
public class BackGroundSpawn : MonoBehaviour {

    private float SpawnTime = 3;
    private float SpawnDelay = 1;
    private bool bio1 = false;
    private bool bio2 = true;
    private bool bio3 = false;

    public Transform spawn;

    public Vector3 spawnPosition;
    public GameObject[] stoneBackgrounds;
    public GameObject[] forestBackgrounds;
   // public GameObject[] Background3;

    private Dictionary<BackgroundType, GameObject[]> map = new Dictionary<BackgroundType, GameObject[]>();
    private BackgroundType backgroundType;
	void Start () {
        backgroundType = BackgroundType.Stone;
        map.Add(BackgroundType.Stone, stoneBackgrounds);
        map.Add(BackgroundType.Forest, forestBackgrounds);
        //StartCoroutine(Bios(2.0f));
        InvokeRepeating("Spawn", SpawnDelay, SpawnTime);

        spawnPosition = spawn.position;
	}
    /*void IEnumerator Bios(){
        yield return new WaitForSeconds(2.0f);
    }*/
	void Spawn () {
        Vector3 disSpawn = new Vector3(0,0,0);
        Vector3 spawnPos = spawnPosition + disSpawn;

        int objLenght = map[backgroundType].Length;
        GameObject obj = map[backgroundType][Random.Range(0, objLenght)];
        Instantiate(obj, spawnPos, transform.rotation);
     /*   int backGroundIndex1 = Random.Range(0, Background1.Length);
        int backGroundIndex2 = Random.Range(0, Background2.Length);
        int backGroundIndex3 = Random.Range(0, Background3.Length);
        if (bio1 == true)
        {
            Instantiate(Background1[backGroundIndex1], spawnPos, transform.rotation);
        }
        else if (bio2 == true)
        {
            Instantiate(Background2[backGroundIndex2], spawnPos, transform.rotation);
        }
        else if (bio3 == true)
        {
            Instantiate(Background3[backGroundIndex3], spawnPos, transform.rotation);
        }
      */
	}
}
