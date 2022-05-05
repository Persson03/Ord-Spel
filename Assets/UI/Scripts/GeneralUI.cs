using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GeneralUI : MonoBehaviour
{
    private Canvas pauseMenu;
    private Canvas settingsMenu;
    private string mainMenuScene = "MainMenu";
    private string nextPlayerGame = "GameScene2";

    private void Start()
    {
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
        Highscore.player1Score = 0;
        Highscore.player2Score = 0;
    }


    //Funkioner för MultiPlayer Knappar

    //När man är i "Nästa spelare Rutan" Om man spelar MultiPlayer och klickar på knappen så startar nästa spel.
    public void NextPlayerTurn()
    {
        SceneManager.LoadScene(nextPlayerGame);
    }

}
