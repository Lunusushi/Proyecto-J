using UnityEngine;

public class PajaroScriptJ1 : MonoBehaviour
{
    public Rigidbody2D cuelpo;
    public float velocidad;   
    public LogicScriptJ1 logicJ1;
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logicJ1 = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScriptJ1>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive == true)
        {
            cuelpo.velocity = cuelpo.velocity = Vector2.up * velocidad;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        logicJ1.gameOver();
    }
}
