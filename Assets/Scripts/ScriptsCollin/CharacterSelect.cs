using UnityEngine;
using System.Collections;
using System.IO;

public class CharacterSelect : MonoBehaviour
{
    public GameObject chars;
    private CharacterSLide charSlideScript;

    private SelectedCharacter selChar;

    public GameObject persistentObject;
    // Use this for initialization
    void Start()
    {
        charSlideScript = chars.GetComponent<CharacterSLide>();
        selChar = persistentObject.GetComponent<SelectedCharacter>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(moveDirection.x);
    }

    void OnMouseDown()
    {
        if(gameObject.name == "Left")
        {
            charSlideScript.slideLeft();
        }
        else if(gameObject.name == "Right")
        {
            charSlideScript.slideRight();
        }
        else if(gameObject.name == "Confirm")
        {
            selChar.selChar = charSlideScript.getSelectedChar();
            Application.LoadLevel(1);
            Debug.Log("Yolo");
        }
    }
}
