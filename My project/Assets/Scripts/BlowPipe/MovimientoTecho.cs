using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovimientoTecho : MonoBehaviour
{
    public float velRate = 1f;
    public bool changeDir = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 7)
        {
            changeDir = true;
        }
        if (transform.position.y < 3)
        {
            changeDir = false;
        }
        if (changeDir == true)
        {
            transform.position = transform.position + (Vector3.down * velRate) * Time.deltaTime;
        }
        if (changeDir == false)
        {
            transform.position = transform.position + (Vector3.up * velRate) * Time.deltaTime;
        }
    }
}
