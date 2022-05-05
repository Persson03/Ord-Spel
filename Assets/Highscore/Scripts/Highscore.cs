using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Highscore : MonoBehaviour
{

    

    public static int player1Score;
    public static int player2Score;

    private bool player1turn;

    private void Start()
    {
        player1turn = true;
    }

    public void AddScore(int score) //Använd den här i andra script för att lägga till score till spelarna. EXEMPEL: Highscore.AddScore(10);
    {
        if(ModeSelection.singlePlayer == true)
        {
            player1Score += score;
        }
        else
        {
            if (player1turn == true)
            {
                player1Score += score;
                player1turn = false;
            }
            else
            {
                player2Score += score;
                player1turn = true;
            }
        }
    }
}
