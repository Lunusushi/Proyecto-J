using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prenderbuton : MonoBehaviour
{
    public GameObject contador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void apagar()
    {
        contador.SetActive(false);
    }

    public void prender()
    {
        contador.SetActive(true);
    }
}
