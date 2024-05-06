using UnityEngine;

//T(n) = 5t + t + 4tn + 2t
//     = 8t + 4tn;
//O()  = n;
public class PajaroScriptJ1 : MonoBehaviour
{
    public Rigidbody2D cuelpo; //t
    public float velocidad;   //t
    public LogicScriptJ1 logicJ1; //t
    public bool isAlive = true; //2t
    //t() = 5t
    void Start() //t() = t
    {
        logicJ1 = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScriptJ1>(); //t
    }

    // Update is called once per frame
    void Update() //n   t() = 4tn
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive == true) //2t
        {
            cuelpo.velocity = Vector2.up * velocidad; //2t
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) //t() = 2t
    {
        isAlive = false; //t
        logicJ1.gameOver(); //t
    }
}
