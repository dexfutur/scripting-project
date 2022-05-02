using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    
     
     
    public void EscenaJuego(string name){
        SceneManager.LoadScene(name);
    }
    public void volver(){
       SceneManager.LoadScene("MainMenu");
    }
   
    public void Salir(){
        Application.Quit();
    }
}
