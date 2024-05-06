using UnityEngine;
using UnityEngine.SceneManagement;

public class pantallaFinalScriptBot : MonoBehaviour
{
    public GameObject ganaJ1, ganaBot, Empate, pantallaFinal;
    PajaroScriptJ1 check1;
    BotScript checkBot;
    LogicScriptJ1 punt1;
    botLogic puntBot;
    void Start()
    {
        // esto sirve para poder acceder a los puntajes y los bools que indican si el jugador sigue vivo.
        check1 = FindObjectOfType<PajaroScriptJ1>();
        checkBot = FindObjectOfType<BotScript>();
        punt1 = FindObjectOfType<LogicScriptJ1>();
        puntBot = FindObjectOfType<botLogic>();
    }

    void Update()
    {
        //esto se ejecuta si ambos jugadores perdieron.
        if (check1.isAlive == false && checkBot.isAlive == false)
        {
            menu();
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

    void showTexto()
    {
        //Esto simplemente habilita los textos de la pantalla final dependiendo de quien gano.
        if (punt1.p1Score > puntBot.BotScore)
        {
            ganaJ1.SetActive(true);
        }

        if (punt1.p1Score < puntBot.BotScore)
        {
            ganaBot.SetActive(true);
        }

        if (punt1.p1Score == puntBot.BotScore)
        {
            Empate.SetActive(true);
        }
    }

    void menu() //Esta funcion contiene la pantalla final y la funcion de mostrar el texto.
    {
        pantallaFinal.SetActive(true);
        showTexto();
    }

}
