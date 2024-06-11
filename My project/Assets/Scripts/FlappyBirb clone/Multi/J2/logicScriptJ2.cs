using UnityEngine;
using UnityEngine.UI;

//T() = 4t + t + 4t + t
//    = 10t;
//O() = 1;
public class LogicScriptJ2 : MonoBehaviour
{
    public int p2Score; //t
    public Text scoreTextP2; //t
    public GameObject GameOverScreenJ2; //t
    PajaroScriptJ2 checkP2; //t
    //t() = 4t

    void Start() //t() = t
    {
        checkP2 = FindObjectOfType<PajaroScriptJ2>(); //t
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) //t() = 4t
    {
        if (checkP2.isAlive == true) //t
        {
            p2Score = p2Score + scoreToAdd; //2t
            scoreTextP2.text = p2Score.ToString(); //t
        }
        
    }
    public void gameOver() //t() = t
    {
        GameOverScreenJ2.SetActive(true); //t
    }

}
