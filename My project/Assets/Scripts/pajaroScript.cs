using System.Collections;
using System.Collections.Generic;
using NumericsVector2 = System.Numerics.Vector2;
using UnityEngine;

public class PajaroScript : MonoBehaviour
{
    public Rigidbody2D cuelpo;
    public float velocidad;   
    public logicScript logic;
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive == true)
        {
            cuelpo.velocity = cuelpo.velocity = Vector2.up * velocidad;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        logic.gameOver();
    }
}
