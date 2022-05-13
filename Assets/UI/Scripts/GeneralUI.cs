using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GeneralUI : MonoBehaviour
{
    private GameManager gameManager;

    private Canvas pauseMenu;
    private Canvas settingsMenu;
    private string mainMenuScene = "MainMenu";
    private string nextPlayerGame = "GameScene2";
    private string highScoresScene = "HighScores";


    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();


        pauseMenu = GameObject.Find("Paus Menu").GetComponent<Canvas>();
        settingsMenu = GameObject.Find("Settings Menu").GetComponent<Canvas>();
        pauseMenu.enabled = false; // Så Paus Menyn alltid startar stängd
        settingsMenu.enabled = false;// Så Settings Menyn alltid startar stängd
    }

    private void Update()
    {
        // Input.ESC & Paus menyn är öppen = stäng menyn / Annars om Input.ESC & Paus menyn är stängd = öppna menyn 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseMenu.enabled == true)
            {
                pauseMenu.enabled = false;
            }
            else
            {
                pauseMenu.enabled = true;
            }
        }
    }

    // Funktioner för paus Knapparna:
    public void OpenSettingsMenu()
    {
        settingsMenu.enabled = true;
        pauseMenu.enabled = false;
    }

    public void ClosePauseMenu()
    {
        pauseMenu.enabled = false;
    }

    public void CloseSettingsMenu()
    {
        settingsMenu.enabled = false;
    }

    public void QuitToMain()
    {
        SceneManager.LoadScene(mainMenuScene);
        ModeSelection.player1Turn = true;
        Timer.timerActivated = false;
        Score.player1Score = 0;
        Score.player2Score = 0;
    }

    public void OpenHighScores()
    {
        SceneManager.LoadScene(highScoresScene);
    }


    //Funkioner för MultiPlayer Knappar

    //När man är i "Nästa spelare Rutan" Om man spelar MultiPlayer och klickar på knappen så startar nästa spel.
    public void NextPlayerTurn()
    {
        Timer.timerActivated = true;
        SceneManager.LoadScene(nextPlayerGame);
        ModeSelection.player1Turn = false;
    }

    

}
