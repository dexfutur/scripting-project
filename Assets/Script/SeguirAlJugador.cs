using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirAlJugador : MonoBehaviour
{
    public GameObject personaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2 (personaje.transform.position.x-8, personaje.transform.position.y+30);

    }
}
