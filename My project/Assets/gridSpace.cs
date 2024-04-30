using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gridSpace : MonoBehaviour
{
    private controlJuego miControl;

    public Button miBoton;

    public TextMeshProUGUI textoBoton;

    public string delJugador;

    private void Start()
    {
        miBoton = GetComponent<Button>();
        textoBoton = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void PonerEspacio()
    {
        textoBoton.text = miControl.ObtenDelJugador();
        miBoton.interactable = false;
        miControl.finalTurno();
    }

    public void ponerControl(controlJuego control)
    {
        miControl = control;
    }




}
