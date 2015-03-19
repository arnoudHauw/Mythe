using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    const string healthString = "Health : ";
    public Text health;
    public float healthValue;
    TorchScript torch;
    const string player = "Player";
    // Use this for initialization
    void Start()
    {
        torch = GameObject.FindGameObjectWithTag(player).GetComponent<TorchScript>();
        healthValue = Mathf.Round(torch.torchHealth);
        health.text = healthString + healthValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        healthValue = Mathf.Round(torch.torchHealth);
        setHealth(healthValue);
    }

    void setHealth(float healthValue) 
    {
        health.text = healthString + healthValue.ToString();
    }
}
