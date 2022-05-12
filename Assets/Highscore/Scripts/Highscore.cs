using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    private Text singleplayerText;

    private GameManager gameManager;

    [SerializeField]private GameObject highScoreObject;
    [SerializeField]private GameObject multiPlayerScores;
    [SerializeField] private GameObject singlePlayerScores;
    private GameObject multiPlayerScoreHolder;

    private void Start()
    {
        ModeSelection.singlePlayer = true;
        ClearMultiPlayerHighScores();

        multiPlayerScoreHolder = GameObject.Find("MScores");
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        singleplayerText = GameObject.Find("SingleplayerText").GetComponent<Text>();
        singleplayerText.text = "";
        gameManager.Load();
        ShowHighscores();
    }

    private void ShowHighscores()
    {
        //Kollar om det är multiplayer
        if (ModeSelection.singlePlayer == false)
        {
            multiPlayerScores.SetActive(true);
            singlePlayerScores.SetActive(false);

            int numberOfHighScores = gameManager.data.playerName.Length;
            for(int i = 0; i < numberOfHighScores; i++)
            {
                InstantiateScores();
            }
        }
        else
        {
            singlePlayerScores.SetActive(true);
            multiPlayerScores.SetActive(false);
            if(gameManager.data.singlePlayerHighScore > 0)
            {
                singleplayerText.text = "Ditt Highscore är: " + gameManager.data.singlePlayerHighScore.ToString();
            }
            else
            {
                singleplayerText.text = "Ditt Highscore är: 0";
            }
            
        }
    }

    public void SingleplayerHighscores()
    {
        ModeSelection.singlePlayer = true;
        ShowHighscores();
    }
    public void MultiplayerHighscores()
    {
        ModeSelection.singlePlayer = false;
        ShowHighscores();
    }

    private void InstantiateScores()
    {
        ClearMultiPlayerHighScores();
        int numberOfNames = gameManager.data.playerName.Length;
        for (int i = 0; i < numberOfNames; i++)
        {
            GameObject OBJ = Instantiate(highScoreObject) as GameObject;
            OBJ.transform.SetParent(multiPlayerScoreHolder.transform);
            OBJ.GetComponent<Text>().text = gameManager.data.playerName[i].ToString() + "'s HighScore: " + gameManager.data.playerHighScore[i].ToString();
        }
    }

    private void ClearMultiPlayerHighScores()
    {
        for (int i = 0; i < GameObject.FindGameObjectsWithTag("highscore").Length; i++)
        {
            if (GameObject.FindGameObjectsWithTag("highscore")[i].GetComponent<SelfDestruct>())
                GameObject.FindGameObjectsWithTag("highscore")[i].GetComponent<SelfDestruct>().DestructSelf();
        }
    }
    
        
      
}
