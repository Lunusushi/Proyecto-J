using UnityEngine;
using UnityEngine.SceneManagement;

public class pantallaFinalScript : MonoBehaviour
{
    public GameObject pantallaFinal;
    public GameObject ganaJ1;
    public GameObject ganaJ2;
    public GameObject Empate;
    PajaroScriptJ1 check1;
    PajaroScriptJ2 check2;
    LogicScriptJ1 punt1;
    LogicScriptJ2 punt2;
    void Start()
    {
        check1 = FindObjectOfType<PajaroScriptJ1>();
        check2 = FindObjectOfType<PajaroScriptJ2>();
        punt1 = FindObjectOfType<LogicScriptJ1>();
        punt2 = FindObjectOfType<LogicScriptJ2>();
    }

    void Update()
    {
        if (check1.isAlive == false && check2.isAlive == false)
        {
            menu();
        }
    }

    public void reiniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void otroJuego()
    {

    }

    public void salir()
    {

    }

    void showTexto()
    {
        if (punt1.p1Score > punt2.p2Score)
        {
            ganaJ1.SetActive(true);
        }

        if (punt1.p1Score < punt2.p2Score)
        {
            ganaJ2.SetActive(true);
        }

        if (punt1.p1Score == punt2.p2Score)
        {
            Empate.SetActive(true);
        }
    }

    void menu()
    {
        pantallaFinal.SetActive(true);
        showTexto();
    }

}
