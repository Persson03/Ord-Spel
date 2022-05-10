using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    private Text player1Text;
    private Text player2Text;
    private Text singleplayerText;

    private void Start()
    {
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
            //Tittar vems highscore som är störst
            player1Text.text = "";
            player2Text.text = "";
            singleplayerText.text = "";
            if (PlayerPrefs.GetInt("HighScorePlayer1") >= PlayerPrefs.GetInt("HighScorePlayer2"))
            {
                player1Text.text = "Player 1's Highscore: " + PlayerPrefs.GetInt("HighScorePlayer1").ToString();
                player2Text.text = "Player 2's Highscore: " + PlayerPrefs.GetInt("HighScorePlayer2").ToString();
            }
            else if (PlayerPrefs.GetInt("HighScorePlayer1") < PlayerPrefs.GetInt("HighScorePlayer2"))
            {
                player1Text.text = "Player 2's Highscore: " + PlayerPrefs.GetInt("HighScorePlayer2").ToString();
                player2Text.text = "Player 1's Highscore: " + PlayerPrefs.GetInt("HighScorePlayer1").ToString();
            }
            if (PlayerPrefs.GetInt("HighScorePlayer1") <= 0)
            {
                player1Text.text = "";
            }
            if (PlayerPrefs.GetInt("HighScorePlayer2") <= 0)
            {
                player2Text.text = "";
            }
        }
        else
        {
            player1Text.text = "";
            player2Text.text = "";
            singleplayerText.text = "";
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
