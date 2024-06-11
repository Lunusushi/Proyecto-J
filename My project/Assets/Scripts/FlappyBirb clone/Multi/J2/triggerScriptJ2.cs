using UnityEngine;

//T(n) = t + t + 2t
//     = 5t
//O() = 1;

public class triggerScriptJ2 : MonoBehaviour
{
    public LogicScriptJ2 logicJ2; //t
    // Start is called before the first frame update
    void Start() //t() = t
    {
        logicJ2 = GameObject.FindGameObjectWithTag("Logic2").GetComponent<LogicScriptJ2>(); //t
    }

    private void OnTriggerEnter2D(Collider2D collision) //t() = 2t
    {
        if(collision.gameObject.layer == 3) //t
        {
            logicJ2.addScore(1); //t
        }
        
    }
}
