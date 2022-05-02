using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlPause : MonoBehaviour
{
    [SerializeField]
    public Slider slider;
    public float sliderValue;
    public Button buttonMute;
    public float valorAnterior;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("sliderVolumen", 0.5f);   
        slider.value = PlayerPrefs.GetFloat("sliderVolumen");
        AudioListener.volume = slider.value;
        sliderValue = slider.value;
                
      
    }

    public void ChangedSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("sliderVolumen", sliderValue);
        AudioListener.volume = slider.value;
        
    }

      

    public void setMute()
    {
        

        if (sliderValue == 0)
        {
            PlayerPrefs.SetFloat("SliderVolumen", valorAnterior);
            slider.value = PlayerPrefs.GetFloat("SliderVolumen");
            AudioListener.volume = slider.value;
        }
        else
        {
            valorAnterior = slider.value;
            PlayerPrefs.SetFloat("SliderVolumen", 0.0f);
            slider.value = PlayerPrefs.GetFloat("SliderVolumen");
            AudioListener.volume = slider.value;
        }

        
    }

    public void volverMenu(){
       SceneManager.LoadScene("MainMenu");
    }
}
