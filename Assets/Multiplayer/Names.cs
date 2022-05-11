using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Names : MonoBehaviour
{
    private GameManager gameManager;
    private GameData gameData;
    
    [SerializeField] private string MultiplayerGameScene;

    //nameList.Add(Input.Player1);
    //Debug.Log(nameList[0]);

    private InputField inputField1;
    private InputField inputField2;
    private string name1;
    private string name2;

    private string[] nameInputs;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        inputField1 = GameObject.Find("Player1Input").GetComponent<InputField>();
        inputField2 = GameObject.Find("Player2Input").GetComponent<InputField>();

        
    }

    public void ChangeName1(string text)
    {
        if (text != null)
        {
            name1 = text;
        }
    }

    public void ChangeName2(string text)
    {
        if (text != null)
        {
            name2 = text;
        }
    }

    public void SaveNames()
    {
        gameManager.data.AddName(name1, Score.player1HighScore);
        gameManager.data.AddName(name2, Score.player2HighScore);
    }

    public void StartMultiplayerGame()
    {
        SaveNames();
        SceneManager.LoadScene(MultiplayerGameScene);
        Timer.timerActivated = true;
    }


}
