using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameData
{

    public Dictionary<string, List<int>> playerScoreDict = new Dictionary<string, List<int>>();
    public int singlePlayerHighScore;

    public void AddNameAndScore(string name, int score)
    {
        if (playerScoreDict.TryGetValue(name, out List<int> scores))
        {
            playerScoreDict[name].Add(score);
        }
        else
        {
            playerScoreDict.Add(name, new List<int>() { score });
        }

        playerScoreDict[name] = playerScoreDict[name].OrderByDescending(i => i).ToList();
    }
    
    /*public void AddName(string name, int score)
    {
        //Om det namnet INTE finns med i listan
        //Lägger till namnet i listan och sätter den score du fick som highscore
        if(!playerName.Contains(name))
        {
            playerName.Add(name);
            playerHighScore.Add(score);
        }
        else
        {
            //Om det namnet FINNS MED i listan
            //kollar vilken plats ditt namn är i listan, och om ditt score är högre än ditt highscore så blir det nya highscoret.
            for (int i = 0; i < playerName.Count; i++)
            {
                if (playerName[i].Contains(name))
                {
                    if(playerHighScore[i] < score)
                    {
                        playerHighScore[i] = score;
                    }
                }
            }
        }
    }
    */
        
    
}

