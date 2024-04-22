using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
   public void inicioJuego()
    {
        SceneManager.LoadScene(1); // 1 debe ser lo que pasa al apretar jugar
    }

    public void salirdeJuego()
    {
        Application.Quit();
    }
}
