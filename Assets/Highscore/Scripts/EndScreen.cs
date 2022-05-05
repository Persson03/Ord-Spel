using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    [SerializeField]private string introductionPlayer1 = "Spelare 1 Score: ";
    [SerializeField] private string introductionPlayer2 = "Spelare 2 Score: ";
    [HideInInspector]public bool hasSetScore;
    private Text Score1;
    private Text Score2;


    private void Start()
    {
        Score1 = GameObject.Find("Highscore1").GetComponent<Text>();
        Score2 = GameObject.Find("Highscore2").GetComponent<Text>();
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
            Score1.text = "Ditt Highscore: " + Highscore.player1Score.ToString();
            Score2.text = "";
        }
        else
        {
            Score1.text = introductionPlayer1 + Highscore.player1Score.ToString();
            Score2.text = introductionPlayer2 + Highscore.player2Score.ToString();
        }
    }
}
