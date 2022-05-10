using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefactoryTowerPlayer : MonoBehaviour
{
    public GameObject torres;
    public GameObject torre;
    public GameObject pisos;
    public GameObject torrePlayer;
    public GameObject player;
    public int cantPisos;
    public int positionInY;
    private void OnMouseDown()
    {
        Debug.Log("ha seleccionado");
        positionInY = 90;
      
       
       

    }

    public void Refactory()
    {
        torres = GameObject.FindGameObjectWithTag("Canvas");
        torrePlayer = GameObject.FindGameObjectWithTag("TorrePlayer");
        pisos = GameObject.FindGameObjectWithTag("PisosSiguientes");

        if (pisos == null)
        {

            Instantiate(torre, new Vector3(torrePlayer.transform.position.x, torrePlayer.transform.position.y + positionInY, transform.position.y), Quaternion.identity).transform.SetParent(torres.transform);


        }
        else
        {
            cantPisos = GameObject.FindGameObjectsWithTag("PisosSiguientes").Length;
            for (int i = 0; i < cantPisos; i++)
            {
                positionInY += 90;
            }

            Instantiate(torre, new Vector3(torrePlayer.transform.position.x, torrePlayer.transform.position.y + positionInY, transform.position.y), Quaternion.identity).transform.SetParent(torres.transform);


        }

        GameObject.FindGameObjectWithTag("Player").transform.SetParent(torrePlayer.transform);

        DestroyImmediate(gameObject);
    }


    }



