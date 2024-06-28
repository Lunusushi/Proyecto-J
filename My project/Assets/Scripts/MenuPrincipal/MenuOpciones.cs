using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{
    public TMPro.TMP_Dropdown resolucionesDropdown;

    Resolution[] resoluciones;

    public AudioMixer audioMixer;

    void Start()
    {
        resoluciones = Screen.resolutions;

        resolucionesDropdown.ClearOptions();

        List<string> opciones = new List<string>();

        int indiceResActual = 0;

        for (int i = 0; i < resoluciones.Length; i++)
        {
            string opcion = resoluciones[i].width + " x " + resoluciones[i].height;
            opciones.Add(opcion);

            if (resoluciones[i].width == Screen.currentResolution.width && resoluciones[i].height == Screen.currentResolution.height)
            {
                indiceResActual = i;
            }
        }

        resolucionesDropdown.AddOptions(opciones);
        resolucionesDropdown.value = indiceResActual;
        resolucionesDropdown.RefreshShownValue();
    }

    public void atras()
    {
        SceneManager.LoadScene(0);
    }

    public void cambiarRes(int indiceRes)
    {
        Resolution resolucion = resoluciones[indiceRes];
        ResolutionManager.instance.CambiarResolucion(resolucion.width, resolucion.height, Screen.fullScreen);
    }

    public void Calidad(int indiceCalidad)
    {
        QualitySettings.SetQualityLevel(indiceCalidad);
    }

    public void pantallacompleta(bool esPantComp)
    {
        ResolutionManager.instance.CambiarPantallaCompleta(esPantComp);
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }


}
