using UnityEngine;

public class BotScript : MonoBehaviour
{
    public Rigidbody2D cuerpo;
    public float velocidad, flapInterval, flapValue, nextFlapTime;
    public botLogic botLogic;
    public Transform obstacleDetector;
    public LayerMask obstacleLayer;
    public bool isAlive = true;

    void Start()
    {
        botLogic = GameObject.FindGameObjectWithTag("Logic2").GetComponent<botLogic>();
    }

    void Update()
    {
        if (isAlive)
        {
            ObstacleDetection();
            Flap();
        }
    }

    void Flap()
    {
        if (Time.time >= nextFlapTime)
        {
            cuerpo.velocity = Vector2.up * velocidad;
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
        botLogic.gameOver();
    }
}
