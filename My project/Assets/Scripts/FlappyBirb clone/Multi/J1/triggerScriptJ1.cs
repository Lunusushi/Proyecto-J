using UnityEngine;

//Virtualmente igual al triggerScriptJ2, entonces:
//T(n) = 5t
//O() = 1
public class triggerScriptJ1 : MonoBehaviour
{
    public LogicScriptJ1 logicJ1;
    
    void Start()
    {
        logicJ1 = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScriptJ1>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logicJ1.addScore(1);
        }
        
    }
}
