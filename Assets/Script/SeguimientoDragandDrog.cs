using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoDragandDrog : MonoBehaviour
{
    public GameObject personaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2 (personaje.transform.position.x, personaje.transform.position.y);

    }
}
