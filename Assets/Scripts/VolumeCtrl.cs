using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeCtrl : MonoBehaviour
{
   public AudioMixer mixer;
   public Slider slider;
   
   void Start()
   {
   slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
   }
   
   public void Setlevel (float sliderValue)
   {
   mixer.SetFloat ("MusicVol", Mathf.Log10 (sliderValue) *20);
   PlayerPrefs.SetFloat("MusicVolume",sliderValue);
   }
}
