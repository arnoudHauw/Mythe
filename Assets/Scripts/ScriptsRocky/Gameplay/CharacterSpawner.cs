using UnityEngine;
using System.Collections;

public class CharacterSpawner : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        
        
        Instantiate(GameObject.FindGameObjectWithTag("PersistentObject").GetComponent<SelectedCharacter>().selChar, transform.position, transform.rotation);
	}
}
