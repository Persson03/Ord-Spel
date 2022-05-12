using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    [HideInInspector]public bool hasSetScore;
    private Text score1;
    private Text score2;


    private void Start()
    {
        score1 = GameObject.Find("Highscore1").GetComponent<Text>();
        score2 = GameObject.Find("Highscore2").GetComponent<Text>();
        hasSetScore = false;
    }

    private void Update()
    {
        if(!hasSetScore)
        {
            SetHighScore();
            hasSetScore = true;
        }
    }

    private void SetHighScore()
    {
        if(ModeSelection.singlePlayer == true)
        {
            score1.text = "Ditt Score: " + Score.singlePlayerScore.ToString();
            score2.text = "";
        }
        else
        {
            score1.text = Names.name1 + "'s Score: " + Score.player1Score.ToString();
            score2.text = Names.name2 + "'s Score: " + Score.player2Score.ToString();
        }
    }
}
