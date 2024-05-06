using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botScoreTrigger : MonoBehaviour
{
    public botLogic logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic2").GetComponent<botLogic>();
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
        
    }
}
