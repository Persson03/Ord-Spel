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
    public string BtnLetter4;
    public string BtnLetter5;
    public string BtnLetter6;
    public string BtnLetter7;
    public string BtnLetter8;
    public string BtnLetter9;






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
        BtnLetter4 = "B";
        BtnLetter5 = "V";
        BtnLetter6 = "G";
        BtnLetter7 = "K";
        BtnLetter8 = "J";
        BtnLetter9 = "M";

        //Change Letter On Button
        GameObject.Find("Button1").GetComponentInChildren<Text>().text = BtnLetter1;
        GameObject.Find("Button2").GetComponentInChildren<Text>().text = BtnLetter2;
        GameObject.Find("Button3").GetComponentInChildren<Text>().text = BtnLetter3;
        GameObject.Find("Button4").GetComponentInChildren<Text>().text = BtnLetter4;
        GameObject.Find("Button5").GetComponentInChildren<Text>().text = BtnLetter5;
        GameObject.Find("Button6").GetComponentInChildren<Text>().text = BtnLetter6;
        GameObject.Find("Button7").GetComponentInChildren<Text>().text = BtnLetter7;
        GameObject.Find("Button8").GetComponentInChildren<Text>().text = BtnLetter8;
        GameObject.Find("Button9").GetComponentInChildren<Text>().text = BtnLetter9;

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
