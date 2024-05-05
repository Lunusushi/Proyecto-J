using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class triggerScriptJ1 : MonoBehaviour
{
    public LogicScriptJ1 logicJ1;
    // Start is called before the first frame update
    void Start()
    {
        logicJ1 = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScriptJ1>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logicJ1.addScore(1);
        }
        
    }
}
