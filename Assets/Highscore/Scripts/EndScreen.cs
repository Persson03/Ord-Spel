using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    [HideInInspector]public bool hasSetScore;
    private Text Score1;
    private Text Score2;


    private void Start()
    {
        hasSetScore = false;
    }

    private void Update()
    {
        if(hasSetScore == false)
        {
            SetHighScore();
            hasSetScore = true;
        }
    }

    public void SetHighScore()
    {
        if(ModeSelection.singlePlayer == true)
        {
            Score1.text = "Ditt Score: " + Score.singlePlayerScore.ToString();
            Score2.text = "";
        }
        else
        {
            Score1.text = Names.name1 + "'s Score: " + Score.player1Score.ToString();
            Score2.text = Names.name2 + "'s Score: " + Score.player2Score.ToString();
        }
    }
}
