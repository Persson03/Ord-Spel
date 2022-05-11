using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    private Text player1Text;
    private Text player2Text;
    private Text singleplayerText;

    private GameManager gameManager;

    [SerializeField]private GameObject highScoreObject;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        player1Text = GameObject.Find("Player1Text").GetComponent<Text>();
        player2Text = GameObject.Find("Player2Text").GetComponent<Text>();
        singleplayerText = GameObject.Find("SingleplayerText").GetComponent<Text>();
        player1Text.text = "";
        player2Text.text = "";
        singleplayerText.text = "";
        ShowHighscores();
    }

    private void ShowHighscores()
    {
        //Kollar om det är multiplayer
        if (ModeSelection.singlePlayer == false)
        {
            gameManager.Load();
            int numberOfHighScores;
            numberOfHighScores = gameManager.data.playerName.Length;

            //Här ska fixas saker
        }
        else
        {
            singleplayerText.text = "Ditt Highscore är: " + PlayerPrefs.GetInt("HighScoreSingleplayer").ToString();
        }
    }

    public void SingleplayerHighscores()
    {
        ModeSelection.singlePlayer = true;
        ShowHighscores();
    }
    public void MultiplayerHighscores()
    {
        ModeSelection.singlePlayer = false;
        ShowHighscores();
    }
}
