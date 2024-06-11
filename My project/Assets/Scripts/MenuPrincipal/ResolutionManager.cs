using System.Collections;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
    public static ResolutionManager instance;

    void Awake()
    {
        // Singleton pattern to ensure only one instance
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Mark this object to not be destroyed on scene load
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CambiarResolucion(int width, int height, bool fullScreen)
    {
        Screen.SetResolution(width, height, fullScreen);
        StartCoroutine(ActualizarUI());
    }

    public void CambiarPantallaCompleta(bool esPantComp)
    {
        Screen.fullScreen = esPantComp;
        StartCoroutine(ActualizarUI());
    }

    private IEnumerator ActualizarUI()
    {
        yield return new WaitForEndOfFrame();
        Canvas.ForceUpdateCanvases();
    }
}
