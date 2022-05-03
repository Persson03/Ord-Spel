using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    //Button Scripts
    Btn1 button1;
    Btn2 button2;

    //Button Texts
    Btn1 BtnText1;

    //Answer And Guess
    string Guess;
    string Answer;


    //Button States
    public string CurrentLetter;

    //Button Letters
    public string BtnLetter1;
    public string BtnLetter2;
    public string BtnLetter3;






    // Start is called before the first frame update
    void Start()
    {
        //Get button scripts
        button1 = GameObject.Find("Button1").GetComponent<Btn1>();
        button2 = GameObject.Find("Button2").GetComponent<Btn2>();

    }

    // Update is called once per frame
    void Update()
    {
        //Button Letters
        BtnLetter1 = "T";
        BtnLetter2 = "A";
        BtnLetter3 = "L";

        //Change Letter On Button
        GameObject.Find("Button1").GetComponentInChildren<Text>().text = BtnLetter1;
        GameObject.Find("Button2").GetComponentInChildren<Text>().text = BtnLetter2;
        GameObject.Find("Button3").GetComponentInChildren<Text>().text = BtnLetter3;

        Debug.Log(CurrentLetter);

        //Check For Final Guess
        if (Input.GetMouseButtonDown(1))
        {
            GameObject.Find("Answer").GetComponent<Text>().text = GameObject.Find("Guess").GetComponent<Text>().text;
            GameObject.Find("Guess").GetComponent<Text>().text = null;
        }

    }


    public void ChangeLetter()
    {
        if (GameObject.Find("Guess").GetComponent<Text>().text != null)
        {
            GameObject.Find("Guess").GetComponent<Text>().text = GameObject.Find("Guess").GetComponent<Text>().text + CurrentLetter;
        }
        else if (GameObject.Find("Guess").GetComponent<Text>().text == null)
        {
            GameObject.Find("Guess").GetComponent<Text>().text = CurrentLetter;
        }



    }

}
