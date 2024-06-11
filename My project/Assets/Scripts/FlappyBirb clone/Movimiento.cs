using UnityEngine;

//T(n) = 4t + 6tn;
//O() = n;

public class Movimiento : MonoBehaviour
{
    public float moveSpeed = 5; //2t
    public double deadZone = -12.18; //2t
    //t() = 4t
    // Update is called once per frame
    void Update() //t() = n(6t)
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; //4t
        if (transform.position.x < deadZone) //t
        {
            Destroy(gameObject); //t
        }
    }
}
