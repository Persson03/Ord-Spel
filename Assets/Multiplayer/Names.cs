using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Names : MonoBehaviour
{
    public List<string> nameList = new List<string>();
    //nameList.Add(Input.Player1);
    //Debug.Log(nameList[0]);

    private InputField inputText1;
    private InputField inputText2;
    private string nameInput1;
    private string nameInput2;

    private string[] nameInputs;

    private void Start()
    {
        inputText1 = GameObject.Find("Player1Input").GetComponent<InputField>();
        inputText2 = GameObject.Find("Player2Input").GetComponent<InputField>();

    }

    private void Update()
    {
        
    }

    private void SaveNames()
    {
        
    }

}
