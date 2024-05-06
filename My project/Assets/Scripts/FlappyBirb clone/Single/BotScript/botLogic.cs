using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botLogic : MonoBehaviour
{
    public int BotScore;
    public Text scoreTextBot;
    public GameObject GameOverScreenBot;
    BotScript checkBot;
    void Start()
    {
        checkBot = FindObjectOfType<BotScript>();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (checkBot.isAlive == true)
        {
            BotScore = BotScore + scoreToAdd;
            scoreTextBot.text = BotScore.ToString();
        }
        
    }
    public void gameOver()
    {
        GameOverScreenBot.SetActive(true);
    }
}
