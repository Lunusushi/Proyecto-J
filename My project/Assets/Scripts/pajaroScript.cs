using System.Collections;
using System.Collections.Generic;
using NumericsVector2 = System.Numerics.Vector2;
using UnityEngine;

public class PajaroScript : MonoBehaviour
{
    public Rigidbody2D cuelpo;
    public float velocidad;   
    Vector2 movimiento;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            movimiento = cuelpo.velocity = Vector2.up * velocidad;
        }
    }
}
