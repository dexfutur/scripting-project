using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyByContact : MonoBehaviour
{

	// Use this for initialization
	private GameObject personaje;
	private GameObject rival;
	private Animator animatorPersonaje;
	private Animator animatorRival;
	private GameObject nuevoPersonaje;
	private int levelPersonaje;
	private int levelRival;
	private int vida;
	void Start()
	{
		personaje = this.gameObject;
		animatorPersonaje = GetComponent<Animator>();
		levelPersonaje = personaje.GetComponent<Jugador>().getLevel();
		vida = personaje.GetComponent<Jugador>().getVida();

	}

	// Update is called once per frame
	void FixedUpdate()
	{
		animatorPersonaje.SetBool("isAttacking", false);
	}
	private void OnTriggerEnter2D(Collider2D colision)
	{
		if (colision.gameObject.tag == "enemigo")
		{
			rival = colision.gameObject;
			Debug.Log(rival.name);
			animatorRival = rival.GetComponent<Animator>();
			levelRival = rival.GetComponent<Enemigo>().getLevel();
			if (levelPersonaje > levelRival)
			{
				Debug.Log("if Personaje > Zombie");
				animatorRival.SetBool("isDead", true);
				animatorPersonaje.SetBool("isAttacking", true);
				Debug.Log("muerte enemigo");
				Debug.Log(levelPersonaje + " Lvl Personaje antes");
				Debug.Log(levelRival + "Lvl Rival");
				rival.GetComponent<Collider2D>().enabled = false;
				Destroy(rival, 1.5f);
				Destroy(rival.transform.parent.gameObject);
				personaje.GetComponent<Jugador>().setLevel(levelPersonaje + levelRival);
				levelPersonaje = personaje.GetComponent<Jugador>().getLevel();
				Debug.Log(levelPersonaje + " Lvl Personaje despues");
			}
			else if (levelPersonaje <= levelRival)
			{
				Debug.Log("if Personaje < Zombie");
				animatorRival.SetBool("isAttacking", true);
				animatorPersonaje.SetBool("isDead", true);
				Debug.Log("muerte personaje");
				Debug.Log(levelPersonaje + "Lvl Personaje");
				Debug.Log(levelRival + "Lvl Rival");
				Destroy(personaje, 1.5f);
				vida -= 1;
				personaje.GetComponent<Jugador>().setVida(vida);

			}
		}
		else if (colision.gameObject.tag == "obstaculo")
		{
			rival = colision.gameObject;
			Debug.Log(rival.name);
			animatorRival = rival.GetComponent<Animator>();
			levelRival = rival.GetComponent<Obstaculo>().getLevel();
			if (levelPersonaje > levelRival)
			{
				Debug.Log("if Personaje > Obstaculo");
				animatorRival.SetBool("isDead", true);
				animatorPersonaje.SetBool("isAttacking", true);
				Debug.Log("muerte obstaculo");
				Debug.Log(levelPersonaje + " Lvl Personaje antes");
				Debug.Log(levelRival + "Lvl Rival");
				rival.GetComponent<Collider2D>().enabled = false;
				Destroy(rival, 1.5f);
				Destroy(rival.transform.parent.gameObject);
				personaje.GetComponent<Jugador>().setLevel(levelPersonaje + levelRival);
				levelPersonaje = personaje.GetComponent<Jugador>().getLevel();
				Debug.Log(levelPersonaje + " Lvl Personaje despues");

			}
			else if (levelPersonaje <= levelRival)
			{
				Debug.Log("if Personaje < Obstaculo");
				animatorRival.SetBool("isAttacking", true);
				animatorPersonaje.SetBool("isDead", true);
				Debug.Log("muerte personaje");
				Debug.Log(levelPersonaje + "Lvl Personaje");
				Debug.Log(levelRival + "Lvl Rival");
				vida -= 1;
				personaje.GetComponent<Jugador>().setVida(vida);

				if (vida > 0)
                {
					nuevoPersonaje= GameObject.FindGameObjectWithTag("Player");
					nuevoPersonaje = Instantiate(nuevoPersonaje);
					nuevoPersonaje.transform.SetParent(GameObject.FindGameObjectWithTag("TorrePlayer").transform);
					
					nuevoPersonaje.GetComponent<Jugador>().setVida(personaje.GetComponent<Jugador>().getVida());
					Destroy(personaje, 1.5f);
					

				}
                else
                {
					DestroyImmediate(GameObject.FindGameObjectWithTag("Canvas"));
					SceneManager.LoadScene("SampleScene");
				}

					
					

			}
		}
		else if (colision.gameObject.tag == "apoyo")
		{
			rival = colision.gameObject;
			Debug.Log(rival.name);
			animatorRival = rival.GetComponent<Animator>();
			levelRival = rival.GetComponent<Obstaculo>().getLevel();
			animatorRival.SetBool("isDead", true);
			animatorPersonaje.SetBool("isAttacking", true);
			Debug.Log("muerte apoyo");
			Debug.Log(levelPersonaje + " Lvl Personaje antes");
			Debug.Log(levelRival + "Lvl Apoyo");
			rival.GetComponent<Collider2D>().enabled = false;
			Destroy(rival, 1.5f);
			personaje.GetComponent<Jugador>().setLevel(levelPersonaje + levelRival);
			levelPersonaje = personaje.GetComponent<Jugador>().getLevel();
			Debug.Log(levelPersonaje + " Lvl Personaje despues");
		}
	}
}





