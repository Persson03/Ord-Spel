using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Highscore : MonoBehaviour
{
    [SerializeField] private string endScreenScene;
    [SerializeField] private Timer timer;
    [SerializeField] private Text highScore1;
    [SerializeField] private string introductionPlayer1 = "Player 1 highscore: ";

    private int highScore;

    private void Start()
    {
        highScore = 0;
    }

    public void AddScore(int score)
    {
        highScore += score;
    }


    private void Update()
    {
        if(timer.currentTime <= 0)
        {
            SceneManager.LoadScene(endScreenScene);
            highScore1.text = introductionPlayer1 + highScore;
        }
    }
}
