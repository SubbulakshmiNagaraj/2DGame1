using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuEvent : MonoBehaviour
{
    public Slider VolumeSlider;
    public AudioMixer mixer;
    private float value;


    public void Start()
    {
        mixer.GetFloat("volume", out value);
        VolumeSlider.value = value;
    }

    public void SetVolume()
    {
        mixer.SetFloat("volume", VolumeSlider.value);
    }


   public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
}
