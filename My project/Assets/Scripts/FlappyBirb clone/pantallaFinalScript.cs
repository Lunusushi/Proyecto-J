using UnityEngine;
using UnityEngine.SceneManagement;

//T(n) = 8t + 5t + n(5t) + t + 3t + t + 2t + 3t
//     = 23t + 5tn;
//O() = n; 
public class pantallaFinalScript : MonoBehaviour
{
    public GameObject ganaJ1, ganaJ2, Empate, pantallaFinal; //4t
    PajaroScriptJ1 check1; //t
    PajaroScriptJ2 check2; //t
    LogicScriptJ1 punt1; //t
    LogicScriptJ2 punt2; //t
    //t() = 8t
    void Start() //t() = 5t
    {
        // esto sirve para poder acceder a los puntajes y los bools que indican si el jugador sigue vivo.
        check1 = FindObjectOfType<PajaroScriptJ1>(); //t
        check2 = FindObjectOfType<PajaroScriptJ2>(); //t
        punt1 = FindObjectOfType<LogicScriptJ1>(); //t
        punt2 = FindObjectOfType<LogicScriptJ2>(); //t
    }

    void Update() //t() = n(5t)
    {
        //esto se ejecuta si ambos jugadores perdieron.
        if (check1.isAlive == false && check2.isAlive == false) //2t
        {
            menu(); //3t
        }
    }

    public void reiniciarJuego() //t() = t
    {
        //Esto reinicia la escena activa.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //t
    }

    public void otroJuego() //t() = 3t
    {
        //Esto selecciona un juego al azar. Requiere que no salga el mismo activo.
        int numeroRandom = Random.Range(0, 11); //t
        if (numeroRandom <= 5) //t
        {
            SceneManager.LoadScene(3); //t
        }
        else
        {
            SceneManager.LoadScene(4); //t
        }
    }

    public void salir() //t() = t
    {
        //Esta hace que se cargue la escena del Menu Principal.
        SceneManager.LoadScene(0); //t
    }

    void showTexto() //t() = 2t
    {
        //Esto simplemente habilita los textos de la pantalla final dependiendo de quien gano.
        if (punt1.p1Score > punt2.p2Score) //t
        {
            ganaJ1.SetActive(true); //t
        }

        if (punt1.p1Score < punt2.p2Score) //t
        {
            ganaJ2.SetActive(true); //t
        }

        if (punt1.p1Score == punt2.p2Score) //t
        {
            Empate.SetActive(true); //t
        }
    }

    void menu() //Esta funcion contiene la pantalla final y la funcion de mostrar el texto. | t() = 3t
    {
        pantallaFinal.SetActive(true); //t
        showTexto(); //2t
    }

}
