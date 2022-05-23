using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private GameManager gameManager;

    private string mainMenuScene = "MainMenu";

    public static int player1Score;
    public static int player2Score;
    public static int singlePlayerScore;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(Names.name1 + " " + player1Score);
            Debug.Log(Names.name2 + " " + player2Score);
        }
    }

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        gameManager.Load();
    }

    //Använd den här i andra script för att lägga till score till spelarna. EXEMPEL: Highscore.AddScore(10);
    public static void AddScore(int score)
    {
        if(ModeSelection.singlePlayer == true)
        {
            singlePlayerScore += score;
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

        //Tittar om det är multiplayer eller inte
        if(ModeSelection.singlePlayer == false) //MultiPlayer - Sparar namn och scores och skickar till JSON
        {
            SaveNamesAndScores();

            player1Score = 0;
            player2Score = 0;
        }
        else //Singleplayer - Sparar score och skickar till JSON
        {
            if(singlePlayerScore > gameManager.data.singlePlayerHighScore)
            {
                gameManager.data.singlePlayerHighScore = singlePlayerScore;
                gameManager.Save();
            }
            singlePlayerScore = 0;
        }
        
        SceneManager.LoadScene(mainMenuScene);
    }
    private void SaveNamesAndScores()
    {
        gameManager.data.AddName(Names.name1, player1Score);
        gameManager.data.AddName(Names.name2, player2Score);
        gameManager.Save();
    }
}
