using UnityEngine;
using System.Collections;

public class FollowerScript : MonoBehaviour
{
    public GameObject target;

    private Vector3 targetLocation;

    void Start()
    {
        targetLocation = new Vector3(target.transform.position.x, target.transform.position.y, -6);
    }
    // Update is called once per frame
    void Update()
    {
        targetLocation.x = target.transform.position.x;
        targetLocation.y = target.transform.position.y;
        targetLocation.z = -6;

        this.transform.position = targetLocation;
    }
}
