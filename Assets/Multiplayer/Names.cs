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
    public static string name1;
    public static string name2;

    private string[] nameInputs;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        inputField1 = GameObject.Find("Player1Input").GetComponent<InputField>();
        inputField2 = GameObject.Find("Player2Input").GetComponent<InputField>();
        name1 = null;
        name2 = null;

    }

    public void ChangeName1(string text)
    {
        name1 = text;
    }

    public void ChangeName2(string text)
    {
        name2 = text;
    }



    public void StartMultiplayerGame()
    {
        if(name1 != null)
        {
            if(name2 != null)
            {
                SceneManager.LoadScene(MultiplayerGameScene);
                Timer.timerActivated = true;
            }
        }
    }


}
