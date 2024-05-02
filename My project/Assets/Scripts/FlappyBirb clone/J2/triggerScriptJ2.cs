using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class triggerScriptJ2 : MonoBehaviour
{
    public LogicScriptJ2 logicJ2;
    // Start is called before the first frame update
    void Start()
    {
        logicJ2 = GameObject.FindGameObjectWithTag("Logic2").GetComponent<LogicScriptJ2>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logicJ2.addScore(1);
        }
        
    }
}
