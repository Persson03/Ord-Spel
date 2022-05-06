using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelection : MonoBehaviour
{
    [HideInInspector] public static bool singlePlayer;
    [HideInInspector] public static bool player1Turn;

    [Header("Scene Strings")]
    [SerializeField]private string singleplayerMode;
    [SerializeField]private string multiplayerMode;

    //Funktioner för PlayerMode Knapparna:
    public void PlaySinglePlayer()
    {
        Timer.timerActivated = true;
        SceneManager.LoadScene(singleplayerMode);
        singlePlayer = true;
    }

    public void PlayMultiplayer()
    {
        singlePlayer = false;
        player1Turn = true;
        SceneManager.LoadScene(multiplayerMode);
    }
}
