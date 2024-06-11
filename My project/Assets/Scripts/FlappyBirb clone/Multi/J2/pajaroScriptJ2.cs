using UnityEngine;

//T() = 12t + 11tn + 5t + 4t + 2t
//    = 23t + 11tn;
//O() = n;

public class PajaroScriptJ2 : MonoBehaviour
{
    public Rigidbody2D cuelpo; //t
    public float velocidad, flapInterval, flapValue, nextFlapTime; //4t
    public LogicScriptJ2 logicJ2; //t
    public bool isAlive = true; //2t
    bool bot = StaticData.multi; //2t
    public Transform obstacleDetector; //t
    public LayerMask obstacleLayer; //t

    //t() = 12t
    // Start is called before the first frame update
    void Start() //t() = t
    {
        logicJ2 = GameObject.FindGameObjectWithTag("Logic2").GetComponent<LogicScriptJ2>(); //t
    }

    // Update is called once per frame
    void Update() //n  t() = 11tn
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true && isAlive == true && bot == false) //3t
        {
            cuelpo.velocity = Vector2.up * velocidad; //2t
        }
        if (isAlive == true && bot == true) //2t
        {
            Flap(); //5t
            ObstacleDetection(); //4t
        }
    }

    void Flap() //t() = 5t
    {
        if (Time.time >= nextFlapTime) //t
        {
            cuelpo.velocity = Vector2.up * velocidad; //2t
            nextFlapTime = Time.time + flapInterval; //2t
        }
    }

    void ObstacleDetection() //t() = 4t porque es mas probable que se encuentre con obstaculos.
    {
        
        RaycastHit2D hit = Physics2D.Raycast(obstacleDetector.position, Vector2.right, 2f, obstacleLayer); //t
        
        if (hit.collider != null) //t
        {
            
            if (hit.point.y < transform.position.y) //t
            {
                flapInterval = 0.2f; //t
            }
            else
            {
                flapInterval = flapValue; //t
            }
        }
        else
        {
            flapInterval = flapValue; //t
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) //t() = 2t
    {
        isAlive = false; //t
        logicJ2.gameOver(); //t
    }
}
