using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeguirAlJugador : MonoBehaviour
{
    public GameObject personaje;

    

    // Start is called before the first frame update


    void Start()
    {

        if (personaje.tag == "Player")
        {
       gameObject.GetComponent<Text>().text = personaje.GetComponent<Jugador>().getLevel().ToString();

        }
        else if (personaje.tag == "enemigo")
        {
           gameObject.GetComponent<Text>().text = personaje.GetComponent<Enemigo>().getLevel().ToString();
        }
        else if (personaje.tag == "obstaculo")
        {
            gameObject.GetComponent<Text>().text = personaje.GetComponent<Obstaculo>().getLevel().ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(personaje.transform.position.x + 0, personaje.transform.position.y + 45);
        if (personaje.tag == "Player")
        {
            gameObject.GetComponent<Text>().text = personaje.GetComponent<Jugador>().getLevel().ToString();

        }
        else if (personaje.tag == "enemigo")
        {
            gameObject.GetComponent<Text>().text = personaje.GetComponent<Enemigo>().getLevel().ToString();
        }
        else if (personaje.tag == "obstaculo")
        {
            gameObject.GetComponent<Text>().text = personaje.GetComponent<Obstaculo>().getLevel().ToString();
        }
    }
}
