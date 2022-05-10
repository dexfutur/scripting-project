using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTowers : MonoBehaviour
{
    public GameObject Towers;
    // Start is called before the first frame update
    void Start()
    {
      
        Towers = GameObject.FindGameObjectWithTag("Canvas");
        if (Towers != null )
        {
            Towers.GetComponent<Canvas>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
