using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class controlJuego : MonoBehaviour
{
    public GameObject gameOverPanel;
    public TextMeshProUGUI gameOverText;

    public TextMeshProUGUI[] listaBoton;
    private string delJugador;
    private int moveCount;


    private void Awake()
    {
        delJugador = "X";
        moveCount = 0;
        gameOverPanel.SetActive(false);
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
            finJuego();
        }
        //fila del medio
        if (listaBoton[3].text == delJugador && listaBoton[4].text == delJugador && listaBoton[5].text == delJugador)
        {
            finJuego();
        }
        //fila de abajo
        if (listaBoton[6].text == delJugador && listaBoton[7].text == delJugador && listaBoton[8].text == delJugador)
        {
            finJuego();
        }
        //primera columna
        if (listaBoton[0].text == delJugador && listaBoton[3].text == delJugador && listaBoton[6].text == delJugador)
        {
            finJuego();
        }
        //segunda columna
        if (listaBoton[1].text == delJugador && listaBoton[4].text == delJugador && listaBoton[7].text == delJugador)
        {
            finJuego();
        }
        //tercera columna
        if (listaBoton[2].text == delJugador && listaBoton[5].text == delJugador && listaBoton[8].text == delJugador)
        {
            finJuego();
        }
        //diagonal derecha
        if (listaBoton[0].text == delJugador && listaBoton[4].text == delJugador && listaBoton[8].text == delJugador)
        {
            finJuego();
        }
        //diagonal izquierda
        if (listaBoton[2].text == delJugador && listaBoton[4].text == delJugador && listaBoton[6].text == delJugador)
        {
            finJuego();
        }

        if (moveCount >= 9)
        {
            cambiarGameOverText("Empate");
        }

        cambioLado();

    }

    void finJuego()
    {
        for (int i = 0; i < listaBoton.Length; i++)
        {
            listaBoton[i].GetComponentInParent<Button>().interactable = false;
        }

        cambiarGameOverText(delJugador + " Gana ");

    }



    void cambioLado()
    {
        delJugador = (delJugador == "X") ? "O" : "X";
    }

    void cambiarGameOverText(string miTexto)
    {
        gameOverText.text = miTexto;
        gameOverPanel.SetActive(true);

    }

}
