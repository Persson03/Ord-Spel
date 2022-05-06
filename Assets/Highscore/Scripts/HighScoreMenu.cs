using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreMenu : MonoBehaviour
{
    private Text player1Text;
    private Text player2Text;

    private void Start()
    {
        player1Text = GameObject.Find("Player1Text").GetComponent<Text>();
        player2Text = GameObject.Find("Player2Text").GetComponent<Text>();

        //Tittar vems highscore som är störst
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
}
