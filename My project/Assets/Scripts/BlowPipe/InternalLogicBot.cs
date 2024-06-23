using UnityEngine;

public class InternalLogicBot : MonoBehaviour
{
    public Rigidbody2D globito;
    public bool isExploded = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(isExploded);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isExploded = true;
        Debug.Log("Choque");
        Debug.Log(isExploded);
    }
}
