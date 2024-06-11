using UnityEngine;

//T(n) = 7t + 5t + n(2t + 6t) + 5t
//     = 17t + 8tn;
// O() = n;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe; //t
    public float spawnRate = 2; //2t
    public float heightOffset = 5; //2t
    private float timer = 0; //2t

    //t() = 7t
    
    // Start is called before the first frame update
    void Start() //t() = 5t
    {
        spawnPipe(); //5t
    }

    // Update is called once per frame
    void Update() //n  t() = 8tn
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime; //2t
        }
        else
        {
            spawnPipe(); //5t
            timer = 0; //t
        }
    }
    void spawnPipe() // t() = 5t
    {
        float lowestPoint = transform.position.y - heightOffset; //2t
        float highestPoint = transform.position.y + heightOffset; //2t

        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); //t
    }
}
