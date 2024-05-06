using UnityEngine;
using UnityEngine.UI;
//Virtualmente igual a logicScriptJ2, entonces:
//T(n) = 10t
//O() = 1
public class LogicScriptJ1 : MonoBehaviour
{
    public int p1Score;
    public Text scoreTextP1;
    public GameObject GameOverScreenJ1;
    PajaroScriptJ1 checkP1;

    void Start()
    {
        checkP1 = FindObjectOfType<PajaroScriptJ1>();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (checkP1.isAlive == true)
        {
            p1Score = p1Score + scoreToAdd;
            scoreTextP1.text = p1Score.ToString();
        }
        
    }

    public void gameOver()
    {
        GameOverScreenJ1.SetActive(true);
    }

}
