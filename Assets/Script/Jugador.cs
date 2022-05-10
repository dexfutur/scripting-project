using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : Personaje
{
    // Start is called before the first frame update
    private int vida;
    void Start()
    {
        setLevel(3);
        vida = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getVida()
    {
        return vida;
    }

    public void setVida(int vida) { 
        this.vida = vida;
    }
}
