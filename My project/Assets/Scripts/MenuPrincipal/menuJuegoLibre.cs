using UnityEngine;
using UnityEngine.SceneManagement;
public class menuJuegoLibre : MonoBehaviour
{
    public void unJugador()
    {
        bool decision = true;
        bool juegoLibre = true;
        StaticData.multi = decision;
        //SceneManager.LoadScene();
    }


    public void multijugador()
    {
        bool decision = false;
        bool juegoLibre = true;
        StaticData.multi = decision;
        //SceneManager.LoadScene();
    }
    public void botonAtras()
    {
        SceneManager.LoadScene(0);
    }
}
