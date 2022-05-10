using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMusic : MonoBehaviour
{
    public static SingletonMusic instance;
    private void Awake()
    {
        if(SingletonMusic.instance == null)
        {
            SingletonMusic.instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
}
