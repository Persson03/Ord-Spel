using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameData
{

    public string[] playerName;
    public int[] playerHighScore;
    public int singlePlayerHighScore;

    
    public void AddName(string name, int score)
    {
        //Om det namnet INTE finns med i arrayen och inte är null
        //Lägger till namnet i arrayen och sätter den score du fick som highscore
        int scorePlacement = playerName.Length;
        int nameArrayLength = playerName.Length;
        if(!playerName.Contains(name))
        {
            playerName = new string[nameArrayLength + 1];
            playerName[nameArrayLength] = name;

            
            playerHighScore[scorePlacement] = score;
        }
        else
        {
            //Om det namnet FINNS MED i arrayen
            //kollar vilken plats ditt namn är i arrayen, och om ditt score är högre än ditt highscore så blir det nya highscoret.
            for (int i = 0; i < playerName.Length; i++)
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
    
}
