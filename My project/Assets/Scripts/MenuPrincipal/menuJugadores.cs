using UnityEngine;
using UnityEngine.SceneManagement;

public class menuJugadores : MonoBehaviour
{
    public void unJugador()
    {
        bool decision = true;
        StaticData.multi = decision;
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


    public void multijugador()
    {
        bool decision = false;
        StaticData.multi = decision;
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
    public void botonAtras()
    {
        SceneManager.LoadScene(0);
    }
}
