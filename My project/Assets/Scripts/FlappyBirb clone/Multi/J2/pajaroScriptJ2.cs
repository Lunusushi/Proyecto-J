using UnityEngine;

public class PajaroScriptJ2 : MonoBehaviour
{
    public Rigidbody2D cuelpo;
    public float velocidad;   
    public LogicScriptJ2 logicJ2;
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logicJ2 = GameObject.FindGameObjectWithTag("Logic2").GetComponent<LogicScriptJ2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true && isAlive == true)
        {
            cuelpo.velocity = cuelpo.velocity = Vector2.up * velocidad;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        logicJ2.gameOver();
    }
}
