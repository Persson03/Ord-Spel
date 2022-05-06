using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Highscore : MonoBehaviour
{
    private string mainMenuScene = "MainMenu";

    public static int player1Score;
    public static int player2Score;

    public static int player1HighScore;
    public static int player2HighScore;

    private void Start()
    {
        
    }

    //Använd den här i andra script för att lägga till score till spelarna. EXEMPEL: Highscore.AddScore(10);
    public void AddScore(int score)
    {
        if(ModeSelection.singlePlayer == true)
        {
            player1Score += score;
        }
        else
        {
            if(ModeSelection.player1Turn == true)
            {
                player1Score += score;
            }
            else
            {
                player2Score += score;
            }
        }
    }

    //Sparar HighScores när ett spel är klart
    public void FinishGame()
    {
        ModeSelection.player1Turn = true;
        player1HighScore = player1Score;
        player2HighScore = player2Score;
        SceneManager.LoadScene(mainMenuScene);
    }
}
