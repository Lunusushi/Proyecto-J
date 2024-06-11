using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;


public class controlJuego : MonoBehaviour
{
    public GameObject panelX;
    public GameObject panelO;
    public TextMeshProUGUI textoX;
    public TextMeshProUGUI textoO;

    public GameObject gameOverPanel;
    public TextMeshProUGUI gameOverText;
    public GameObject botonReinicio;
    public GameObject botonOtroJ;
    public GameObject botonMenuP;

    public TextMeshProUGUI[] listaBoton;
    private string delJugador;
    private int moveCount;

    bool bot = StaticData.multi;

    private void Awake()
    {
        delJugador = "X";
        panelO.SetActive(false);
        moveCount = 0;
        botonReinicio.SetActive(false);
        gameOverPanel.SetActive(false);
        botonMenuP.SetActive(false);
        botonOtroJ.SetActive(false);
        ponerControlEnBoton();
        

    }



    void ponerControlEnBoton()
    {
        for (int i = 0; i < listaBoton.Length; i++)
        {
            listaBoton[i].GetComponentInParent<gridSpace>().ponerControl(this);
        }
    }

    public string ObtenDelJugador()
    {
        return delJugador;
    }

    public void finalTurno()
    {
        moveCount++;

        //fila de arriba
        if (listaBoton[0].text == delJugador && listaBoton[1].text == delJugador && listaBoton[2].text == delJugador)
        {
            finJuego(delJugador);
        }
        //fila del medio
        else if (listaBoton[3].text == delJugador && listaBoton[4].text == delJugador && listaBoton[5].text == delJugador)
        {
            finJuego(delJugador);
        }
        //fila de abajo
        else if (listaBoton[6].text == delJugador && listaBoton[7].text == delJugador && listaBoton[8].text == delJugador)
        {
            finJuego(delJugador);
        }
        //primera columna
        else if (listaBoton[0].text == delJugador && listaBoton[3].text == delJugador && listaBoton[6].text == delJugador)
        {
            finJuego(delJugador);
        }
        //segunda columna
        else if (listaBoton[1].text == delJugador && listaBoton[4].text == delJugador && listaBoton[7].text == delJugador)
        {
            finJuego(delJugador);
        }
        //tercera columna
        else if (listaBoton[2].text == delJugador && listaBoton[5].text == delJugador && listaBoton[8].text == delJugador)
        {
            finJuego(delJugador);
        }
        //diagonal derecha
        else if (listaBoton[0].text == delJugador && listaBoton[4].text == delJugador && listaBoton[8].text == delJugador)
        {
            finJuego(delJugador);
        }
        //diagonal izquierda
        else if (listaBoton[2].text == delJugador && listaBoton[4].text == delJugador && listaBoton[6].text == delJugador)
        {
            finJuego(delJugador);
        }

        else if (moveCount >= 9)
        {
            finJuego("Empate");
        }
        else
        {
            cambioLado();
            if (delJugador == "O" && bot == true)
            {
                turnoComputador();
            }
        }


    }

    void finJuego(string ganador)
    {
        panelX.SetActive(false);
        panelO.SetActive(false);
        tablaInteractuable(false);
        if (ganador == "Empate")
        {
            cambiarGameOverText("Empate");

        }
        else
        {
            cambiarGameOverText(delJugador + " Gana ");
        }

        botonReinicio.SetActive(true);
        botonMenuP.SetActive(true);
        botonOtroJ.SetActive(true);

    }



    void cambioLado()
    {
        delJugador = (delJugador == "X") ? "O" : "X";
        if (delJugador == "X")
        {
            panelX.SetActive(true);
            panelO.SetActive(false);
            textoX.text = "Turno de: " + delJugador;
        }
        else
        {
            panelO.SetActive(true);
            panelX.SetActive(false);
            textoX.text = "Turno de: " + delJugador;
        }

    }

    void cambiarGameOverText(string miTexto)
    {
        gameOverText.text = miTexto;
        gameOverPanel.SetActive(true);

    }

    void tablaInteractuable(bool activacion)
    {
        for (int i = 0; i < listaBoton.Length; i++)
        {
            listaBoton[i].GetComponentInParent<Button>().interactable = activacion;
        }
    }

    public void reinicioJuego()
    {
        delJugador = "X";
        panelX.SetActive(true);
        textoX.text = "Turno de: " + delJugador;
        moveCount = 0;
        gameOverPanel.SetActive(false);

        for (int i = 0; i < listaBoton.Length; i++)
        {
            listaBoton[i].text = "";
        }
        tablaInteractuable(true);
        botonReinicio.SetActive(false);
        botonMenuP.SetActive(false);
        botonOtroJ.SetActive(false);

    }
    public void volverMenuP()
    {
        SceneManager.LoadScene(0);
    }
    public void otroJ()
    {
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

    void turnoComputador()
    {
        bool encontroEspacioSU = false;

        while (!encontroEspacioSU)
        {
            int numeroAzar = Random.Range(0, 9);

            if (listaBoton[numeroAzar].GetComponentInParent<Button>().IsInteractable())
            {
                listaBoton[numeroAzar].GetComponentInParent<Button>().onClick.Invoke();
                encontroEspacioSU = true;
            }
        }
    }
}