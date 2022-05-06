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
    public static void AddScore(int score)
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

        //Tittar om Score är större än Highscore och isåfall sparar den scoren som en highScore
        if (player1Score > PlayerPrefs.GetInt("HighScorePlayer1"))
        {
            player1HighScore = player1Score;
            PlayerPrefs.SetInt("HighScorePlayer1", player1HighScore);
        }
        if(player2Score > PlayerPrefs.GetInt("HighScorePlayer2"))
        {
            player2HighScore = player2Score;
            PlayerPrefs.SetInt("HighScorePlayer2", player2HighScore);
        }
        SceneManager.LoadScene(mainMenuScene);
    }
}
