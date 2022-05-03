using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Ändras i inspektorn
    public string playerModeScene;

    //Funktioner för MainMenu knapparna:
    public void StartGame()
    {
        SceneManager.LoadScene(playerModeScene);
    }

    public void OpenOptions()
    {

    }

    public void CloseOptions()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
