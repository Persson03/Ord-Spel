using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelection : MonoBehaviour
{

    public string singleplayerMode;
    public string multiplayerMode;

    //Funktioner för PlayerMode Knapparna:
    public void PlaySinglePlayer()
    {
        SceneManager.LoadScene(singleplayerMode);
    }

    public void PlayMultiplayer()
    {
        SceneManager.LoadScene(multiplayerMode);
    }
}
