using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScriptJ2 : MonoBehaviour
{
    public int p2Score;
    public Text scoreTextP2;
    public GameObject GameOverScreenJ2;
    PajaroScriptJ2 checkP2;

    void Start()
    {
        checkP2 = FindObjectOfType<PajaroScriptJ2>();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (checkP2.isAlive == true)
        {
            p2Score = p2Score + scoreToAdd;
            scoreTextP2.text = p2Score.ToString();
        }
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreenJ2.SetActive(true);
    }

}
