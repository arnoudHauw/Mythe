using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public GameObject hpBar;
    RectTransform barTransform;
    TorchScript torch;
    float hpBarWidth;
    Vector3 hpBarPosition;
	// Use this for initialization
    void Start()
    {
        torch = GameObject.FindGameObjectWithTag("Player").GetComponent<TorchScript>();
        barTransform = hpBar.transform as RectTransform;
        hpBarWidth = barTransform.rect.width;
    }
	
	// Update is called once per frame
	void Update () 
    {
        Vector3 temp = hpBar.transform.position;
        temp.x += (hpBarWidth / 2) - (hpBarWidth/100)*(100 - torch.torchHealth);
        transform.position = temp;
	}
}
