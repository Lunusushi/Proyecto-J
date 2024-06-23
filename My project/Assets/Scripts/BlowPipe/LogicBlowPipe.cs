using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicBlowPipe : MonoBehaviour
{
    public GameObject P1, P2, PBot, Cont1, Cont2, Roof, GameOverScreen, P1Gana, P2Gana, BotGana, Empate;
    public Contador SecRestP1, SecRestP2;
    public SafeZone currentPlayer;
    public internalLogic Check1, Check2;
    public InternalLogicBot CheckBot;
    public Text scoreTxtP1, scoreTxtP2, currentTurn;
    bool Bot = StaticData.multi;
    public int Score1, Score2, winningCondition;
    // Start is called before the first frame update
    void Start()
    {
        currentPlayer.CurrentPlayer = 1;
        currentTurn.text = "Es turno de\nJugador 1";
    }
    void Update()
    {
        TurnSwap();
    }

    public void AddScore1(int scoreToAdd)
    {
        if (Check1.isExploded == false) 
        {
            Score1 += scoreToAdd;
            scoreTxtP1.text = Score1.ToString();
        }
    }
    public void AddScore2(int scoreToAdd)
    {
        if (Check2.isExploded == false) 
        {
            Score2 += scoreToAdd;
            scoreTxtP2.text = Score2.ToString();
        }
    }

    public void TurnSwap()
    {
        if (Bot == false)
        {
            if (currentPlayer.CurrentPlayer == 1)
            {
                if (Check1.isExploded == true || SecRestP1.TimeLeft == 0)
                {
                    P1.SetActive(false);
                    Cont1.SetActive(false);

                    P2.SetActive(true);
                    Cont2.SetActive(true);
                    currentPlayer.CurrentPlayer = 2;
                    currentTurn.text = "Es turno de\nJugador 2";
                }
                if (Score1 == winningCondition)
                {
                    currentTurn.text = "";
                    currentPlayer.CurrentPlayer = 0;
                    P1.SetActive(false);
                    Cont1.SetActive(false);
                    Roof.SetActive(false);
                    GameOverScreen.SetActive(true);
                    P1Gana.SetActive(true);
                }
            }
            if (currentPlayer.CurrentPlayer == 2)
            {
                if (Check2.isExploded == true || SecRestP2.TimeLeft == 0)
                {
                    currentTurn.text = "";
                    currentPlayer.CurrentPlayer = 0;
                    P2.SetActive(false);
                    Cont2.SetActive(false);
                    Roof.SetActive(false);
                    GameOverScreen.SetActive(true);
                    Empate.SetActive(true);
                }
                if (Score2 == winningCondition)
                {
                    currentTurn.text = "";
                    currentPlayer.CurrentPlayer = 0;
                    P2.SetActive(false);
                    Cont2.SetActive(false);
                    Roof.SetActive(false);
                    GameOverScreen.SetActive(true);
                    P2Gana.SetActive(true);
                }
            }
    
        }
        if (Bot == true)
        {
            if (currentPlayer.CurrentPlayer == 1)
            {
                if (Check1.isExploded == true || SecRestP1.TimeLeft == 0)
                {
                    P1.SetActive(false);
                    Cont1.SetActive(false);

                    PBot.SetActive(true);
                    Cont2.SetActive(true);
                    currentPlayer.CurrentPlayer = 2;
                    currentTurn.text = "Es turno del\nBot";
                }
                if (Score1 == winningCondition)
                {
                    currentTurn.text = "";
                    currentPlayer.CurrentPlayer = 0;
                    P1.SetActive(false);
                    Cont1.SetActive(false);
                    Roof.SetActive(false);
                    GameOverScreen.SetActive(true);
                    P1Gana.SetActive(true);
                }
            }
            if (currentPlayer.CurrentPlayer == 2)
            {
                if (CheckBot.isExploded == true || SecRestP2.TimeLeft == 0)
                {
                    currentTurn.text = "";
                    currentPlayer.CurrentPlayer = 0;
                    PBot.SetActive(false);
                    Cont2.SetActive(false);
                    Roof.SetActive(false);
                    GameOverScreen.SetActive(true);
                    Empate.SetActive(true);
                }
                if (Score2 == winningCondition)
                {
                    currentTurn.text = "";
                    currentPlayer.CurrentPlayer = 0;
                    PBot.SetActive(false);
                    Cont2.SetActive(false);
                    Roof.SetActive(false);
                    GameOverScreen.SetActive(true);
                    BotGana.SetActive(true);
                }
            }
        }
    }
    public void reiniciarJuego() 
    {
        //Esto reinicia la escena activa.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
    public void otroJuego() 
    {
        //Esto selecciona un juego al azar. Requiere que no salga el mismo activo.
        int numeroRandom = Random.Range(0, 11); 
        if (numeroRandom <= 5) 
        {
            SceneManager.LoadScene(3); 
        }
        else
        {
            SceneManager.LoadScene(4); 
        }
    }
    public void salir() 
    {
        //Esta hace que se cargue la escena del Menu Principal.
        SceneManager.LoadScene(0); 
    }
}
