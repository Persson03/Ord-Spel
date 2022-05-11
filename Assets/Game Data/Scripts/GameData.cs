using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameData
{

    public string[] playerName;
    public int[] playerHighScore;
    public int singlePlayerHighScore;
    public void AddName(string name, int highScore)
    {
        if(!playerName.ToList().Contains(name))
        {
            playerName.ToList().Add(name);

            int scorePlacement;
            scorePlacement = playerName.Length;
            playerHighScore[scorePlacement] = highScore;
        }
        else
        {
            //scorePlacement = playerName.Contains(name).Length;
            for (int i = 0; i < playerName.Length; i++)
            {
                if (playerName[i].Contains(name))
                {
                    playerHighScore[i] = highScore;
                }
            }
        }
        
    }
    
}
