using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicBlowPipe : MonoBehaviour
{
    public internalLogic Check;
    public Text scoreTxt;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int scoreToAdd)
    {
        if (Check.isExploded == false)
        {
            Score += scoreToAdd;
            scoreTxt.text = Score.ToString();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
