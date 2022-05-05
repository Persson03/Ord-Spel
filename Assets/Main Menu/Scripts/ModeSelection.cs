using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelection : MonoBehaviour
{
    [HideInInspector] public static bool singlePlayer;

    [Header("Scene Strings")]
    public string singleplayerMode;
    public string multiplayerMode;

    //Funktioner för PlayerMode Knapparna:
    public void PlaySinglePlayer()
    {
        SceneManager.LoadScene(singleplayerMode);
        singlePlayer = true;
    }

    public void PlayMultiplayer()
    {
        SceneManager.LoadScene(multiplayerMode);
        singlePlayer = false;
    }
}
