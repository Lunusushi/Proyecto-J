using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class internalLogic : MonoBehaviour
{
    public Rigidbody2D globito;
    public bool isExploded = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(isExploded);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isExploded = true;
        Debug.Log("Choque");
        Debug.Log(isExploded);
    }
}
