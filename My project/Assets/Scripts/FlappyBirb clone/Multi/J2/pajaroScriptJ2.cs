using UnityEngine;

public class PajaroScriptJ2 : MonoBehaviour
{
    public Rigidbody2D cuelpo;
    public float velocidad, flapInterval, flapValue, nextFlapTime;   
    public LogicScriptJ2 logicJ2;
    public bool isAlive = true;
    bool bot = StaticData.multi;
    public Transform obstacleDetector;
    public LayerMask obstacleLayer;
    // Start is called before the first frame update
    void Start()
    {
        logicJ2 = GameObject.FindGameObjectWithTag("Logic2").GetComponent<LogicScriptJ2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true && isAlive == true && bot == false)
        {
            cuelpo.velocity = cuelpo.velocity = Vector2.up * velocidad;
        }
        if (isAlive == true && bot == true)
        {
            Flap();
            ObstacleDetection();
        }
    }

    void Flap()
    {
        if (Time.time >= nextFlapTime)
        {
            cuelpo.velocity = Vector2.up * velocidad;
            nextFlapTime = Time.time + flapInterval;
        }
    }

    void ObstacleDetection()
    {
        // Cast a Raycast forward to detect obstacles
        RaycastHit2D hit = Physics2D.Raycast(obstacleDetector.position, Vector2.right, 2f, obstacleLayer);

        // Adjust flap interval based on obstacle proximity
        if (hit.collider != null)
        {
            // If obstacle detected below, flap to avoid it
            if (hit.point.y < transform.position.y)
            {
                flapInterval = 0.2f; // Adjust as needed
            }
            else
            {
                flapInterval = flapValue; // Regular flap interval
            }
        }
        else
        {
            flapInterval = flapValue; // Regular flap interval if no obstacle detected
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        logicJ2.gameOver();
    }
}
