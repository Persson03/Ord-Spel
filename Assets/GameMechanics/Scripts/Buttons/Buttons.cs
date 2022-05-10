﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.EventSystems;
using System;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject Setting;

    KeyCode SettingsSubmit;

    //Answer And Guess
    string Guess;
    string Answer;


    //Button States
    public string CurrentLetter;

    //Button Letters
    string UsedAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
    string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

    //checks if letters are randomized
    bool random = false;

    List<string> buttons = new List<string>();
    public string BtnLetter1;
    public string BtnLetter2;
    public string BtnLetter3;
    public string BtnLetter4;
    public string BtnLetter5;
    public string BtnLetter6;
    public string BtnLetter7;
    public string BtnLetter8;
    public string BtnLetter9;

    bool EmptyGuess;
    bool RestartGuess;

    //Valid Words
    HashSet<string> ValidWords = new HashSet<string>(System.IO.File.ReadAllLines("WordList.txt"));

    List<string> UsedWords = new List<string>();
    



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SettingsSubmit = (KeyCode)Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Setting1"));

        Guess = GameObject.Find("Guess").GetComponent<Text>().text;
        Answer = GameObject.Find("Answer").GetComponent<Text>().text;


        //Randomize Button Letters
        if (random == false)
        {
            for (int i = 0; i < 9; i++)
            {
                char c = UsedAlphabet[UnityEngine.Random.Range(0, UsedAlphabet.Length)];
                buttons.Add(char.ToString(c));
                UsedAlphabet = UsedAlphabet.Replace(c.ToString(), "");
            }
            random = true;
            SetButtonLetter();
        }



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

        //check if answer contains valid word
        if (ValidWords.Contains(Answer) && !UsedWords.Contains(Answer))
        {
            GameObject.Find("Answer").GetComponent<Text>().color = Color.green;
            UsedWords.Add(Answer);

            //Add Score
            Score.AddScore(Answer.Length);
        }

        //check if answer does not contain valid word
        if (!ValidWords.Contains(Answer))
        {
            GameObject.Find("Answer").GetComponent<Text>().color = Color.red;
        }


        //Check For Final Guess
        if (Input.GetKeyDown(SettingsSubmit) && EmptyGuess == false)
        {

            if (EmptyGuess == false)
            {

                if (StatusText() == false && Guess.Length > 1)
                {
                    GameObject.Find("Answer").GetComponent<Text>().text = Guess;
                    GameObject.Find("Guess").GetComponent<Text>().text = null;
                    EmptyGuess = true;
                    StatusText();
                }
                else if (Guess.Length <= 1)
                {
                    GameObject.Find("StatusText").GetComponent<Text>().text = "MINST TVÅ BOKSTÄVER!";
                }
            }
        }

        //Remove letter on backspace
        if (Input.GetKeyDown(KeyCode.Backspace) && Guess.Length != 0)
        {
            GameObject.Find("Guess").GetComponent<Text>().text = Guess.Remove(Guess.Length - 1);           
            Debug.Log(Guess);
        }

    }

    public void SetButtonLetter()
    {
        //Assign Button Letters
        BtnLetter1 = buttons[0];
        BtnLetter2 = buttons[1];
        BtnLetter3 = buttons[2];
        BtnLetter4 = buttons[3];
        BtnLetter5 = buttons[4];
        BtnLetter6 = buttons[5];
        BtnLetter7 = buttons[6];
        BtnLetter8 = buttons[7];
        BtnLetter9 = buttons[8];
    }

    public void ResetButtonLetter()
    {
        buttons.Clear();
        UsedAlphabet = Alphabet;
        random = false;
    }
    public bool StatusText()
    {


        if (Guess == Answer && Answer != "")
        {
            GameObject.Find("StatusText").GetComponent<Text>().text = "SKRIV NÅGOT NYTT!";
            RestartGuess = true;
            return true;
        } else if (UsedWords.Contains(Guess))
        {
            GameObject.Find("StatusText").GetComponent<Text>().text = "REDAN ANVÄND!";
            RestartGuess = true;
            return true;
        }
        else
        {
            GameObject.Find("StatusText").GetComponent<Text>().text = null;
            return false;
        }
    }

    public void ChangeLetter()
    {
        if (RestartGuess == true)
        {
            GameObject.Find("Guess").GetComponent<Text>().text = "";
            RestartGuess = false;
        }
        GameObject.Find("Guess").GetComponent<Text>().text += CurrentLetter;
        EmptyGuess = false;

        EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(null);
    }

    public void GameSettings()
    {
        GameObject.Find("SubmitAnswer").GetComponentInChildren<Text>().text = "hej";
    }

}
