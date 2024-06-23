using UnityEngine;
using UnityEngine.SceneManagement;

public class menuJugadores : MonoBehaviour
{
    public void unJugador()
    {
        bool decision = true;
        StaticData.multi = decision;
        ElectorEscena();
    }

    public void multijugador()
    {
        bool decision = false;
        StaticData.multi = decision;
        ElectorEscena();
    }
    public void botonAtras()
    {
        SceneManager.LoadScene(0);
    }

    public void ElectorEscena()
    {
        int numeroRandom = Random.Range(0, 9);
        if(numeroRandom <= 3)
        {
            SceneManager.LoadScene(3);
        }
        if(numeroRandom > 3 && numeroRandom <= 6)
        {
            SceneManager.LoadScene(4);
        }
        if(numeroRandom > 6)
        {
            SceneManager.LoadScene(5);
        }
    }
}
