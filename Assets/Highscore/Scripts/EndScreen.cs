using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    [SerializeField]private string introductionPlayer1 = "Spelare 1 HighScore: ";
    [SerializeField] private string introductionPlayer2 = "Spelare 2 HighScore: ";
    [HideInInspector]public bool hasSetScore;
    private Text highScore1;
    private Text highscore2;
    private Highscore highscore;


    private void Start()
    {
        highScore1 = GameObject.Find("Highscore1").GetComponent<Text>();
        highscore2 = GameObject.Find("Highscore2").GetComponent<Text>();
        highscore = GameObject.Find("Game Manager").GetComponent<Highscore>();
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
            highScore1.text = "Ditt Highscore: " + Highscore.player1Score.ToString();
        }
        else
        {
            highScore1.text = introductionPlayer1 + Highscore.player1Score.ToString();
            highscore2.text = introductionPlayer2 + Highscore.player2Score.ToString();
        }
    }
}
