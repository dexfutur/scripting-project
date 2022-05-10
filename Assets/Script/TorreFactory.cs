using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TorreFactory : MonoBehaviour
{
    public GameObject torreVillian;
    public GameObject torre;
    public GameObject torrePlayer;
    public GameObject torres;
    public GameObject instanciaTorrePlayer;
    public GameObject instanciaPlayer;
    public GameObject zombie1;
    public GameObject zombie2;
    public GameObject zombie3;
    public GameObject obstaculo1;
    public GameObject obstaculo2;
    public GameObject obstaculo3;
    public GameObject torreVillian1;
    public GameObject torreVillian2;
    public GameObject torreVillian3;
    public GameObject jugador;
    public GameObject nivel;
    
    public int cantPisos;
    public int initPosition;

    private static TorreFactory instance;
     void Start()
    {
        
    }

    private void Awake()
    {
        if (TorreFactory.instance == null)
        {
            TowerFactory();
            TorreFactory.instance = this;
            DontDestroyOnLoad(gameObject);
            
        }
        else
        {
           
            Destroy(gameObject);
        }

    }
    public void RandomUser(GameObject obj)
    {
        int lvl_player = jugador.GetComponent<Jugador>().getLevel();
        switch (Random.Range(1, 6))
        {
            case 1:
                zombie1 = Instantiate(zombie1);
                zombie1.GetComponent<Enemigo>().setLevel(Random.Range(1,lvl_player));
                zombie1.transform.SetParent(obj.transform);
                zombie1.transform.position = obj.transform.position;
                nivel = Instantiate(nivel);
                nivel.transform.SetParent(zombie1.transform);
                nivel.GetComponent<SeguirAlJugador>().personaje = zombie1;
                break;
            case 2:
                zombie2 = Instantiate(zombie2);
                zombie2.transform.SetParent(obj.transform);
                zombie2.GetComponent<Enemigo>().setLevel(Random.Range(1, 10));
                zombie2.transform.position = obj.transform.position;
                nivel = Instantiate(nivel);
                nivel.transform.SetParent(zombie2.transform);
                nivel.GetComponent<SeguirAlJugador>().personaje = zombie2;
                break;
            case 3:
                zombie3 = Instantiate(zombie3);
                zombie3.transform.SetParent(obj.transform);
                zombie3.GetComponent<Enemigo>().setLevel(Random.Range(1, lvl_player));
                zombie3.transform.position = obj.transform.position;
                nivel = Instantiate(nivel);
                nivel.transform.SetParent(zombie3.transform);
                nivel.GetComponent<SeguirAlJugador>().personaje = zombie3;
                break;
            case 4:
                obstaculo1 = Instantiate(obstaculo1);
                obstaculo1.transform.SetParent(obj.transform);
                obstaculo1.GetComponent<Obstaculo>().setLevel(Random.Range(1, lvl_player));
                obstaculo1.transform.position = obj.transform.position;
                nivel = Instantiate(nivel);
                nivel.transform.SetParent(obstaculo1.transform);
                nivel.GetComponent<SeguirAlJugador>().personaje = obstaculo1;
                break;
            case 5:
                obstaculo2 = Instantiate(obstaculo2);
                obstaculo2.transform.SetParent(obj.transform);
                obstaculo2.GetComponent<Obstaculo>().setLevel(Random.Range(1, 10));
                obstaculo2.transform.position = obj.transform.position;
                nivel = Instantiate(nivel);
                nivel.transform.SetParent(obstaculo2.transform);
               nivel.GetComponent<SeguirAlJugador>().personaje = obstaculo2;
                break;
            case 6:
                obstaculo3 = Instantiate(obstaculo3);
                obstaculo3.transform.SetParent(obj.transform);
                obstaculo3.GetComponent<Obstaculo>().setLevel(Random.Range(1, lvl_player));
                obstaculo3.transform.position = obj.transform.position;
                Instantiate(nivel).transform.SetParent(obstaculo3.transform);
                nivel = Instantiate(nivel);
                nivel.transform.SetParent(obstaculo3.transform);
                 nivel.GetComponent<SeguirAlJugador>().personaje = obstaculo3;
                break;

            default:

                Debug.Log("No se creo el enemigo");
                break;
        }

        return;
    }
   
    public void TowerFactory()

    {
        jugador = Instantiate(jugador);
        torres = GameObject.FindGameObjectsWithTag("Canvas")[0];
        torrePlayer = Instantiate(torre, new Vector3(transform.position.x - 200, transform.position.y - 268, transform.position.y), Quaternion.identity);
        torrePlayer.transform.SetParent(torres.transform);
        jugador.transform.SetParent(torrePlayer.transform);
        nivel = Instantiate(nivel);
        nivel.transform.SetParent(jugador.transform);
        nivel.GetComponent<SeguirAlJugador>().personaje = jugador;
        initPosition = -268;
        cantPisos = Random.Range(1, 5);

        for(int i = 0; i < cantPisos; i++)
        {

            torreVillian1 = Instantiate(torreVillian, new Vector3(transform.position.x + 200, transform.position.y + (initPosition), transform.position.y), Quaternion.identity);
            torreVillian1.transform.SetParent(torres.transform);
            RandomUser(torreVillian1);
            initPosition += 90;
        }
        initPosition = -268;
        cantPisos = Random.Range(1, 5);

        for (int i = 0; i < cantPisos; i++)
        {

            torreVillian2 = Instantiate(torreVillian, new Vector3(transform.position.x + 340, transform.position.y + (initPosition), transform.position.y), Quaternion.identity);
            torreVillian2.transform.SetParent(torres.transform);
            RandomUser(torreVillian2);
            initPosition += 90;
        }
        initPosition = -268;
        cantPisos = Random.Range(1, 5);

        for (int i = 0; i < cantPisos; i++)
        {

            torreVillian3 = Instantiate(torreVillian, new Vector3(transform.position.x + 480, transform.position.y + (initPosition), transform.position.y), Quaternion.identity);
            torreVillian3.transform.SetParent(torres.transform);
            RandomUser(torreVillian3);
            initPosition += 90;
        }
    }

    
    public void Restart()
    {

        DestroyImmediate(GameObject.FindGameObjectWithTag("Canvas"));
      
    }
}
