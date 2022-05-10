using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlVolumen : MonoBehaviour
{
    [SerializeField] public Slider slider;
    public float sliderValue;
    public Image imageMute;
   

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("Slider", 0.5f);
        AudioListener.volume = slider.value;
        sliderValue=slider.value;
        getMute();
        
    }
    public void ChangedSlider(float valor){
        sliderValue = valor;
        PlayerPrefs.SetFloat("Slider", sliderValue);
        AudioListener.volume = slider.value;
        getMute();
    }
    // Update is called once per frame
    public void getMute()
    {
       if(sliderValue == 0){
           imageMute.enabled = true;
          

       }else{
          
           imageMute.enabled = false;
       }
        
    }

   
}
