using UnityEngine;
using System.Collections;

public class BarrelScript : MonoBehaviour
{

    private GameObject thePlayer;
    private TorchScript torchScr;
    void Start()
    {
        thePlayer = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        torchScr = thePlayer.GetComponent<TorchScript>();
        torchScr.torchHealth = 10;
    }
}
