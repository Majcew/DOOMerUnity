using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetMusicVol : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;

    float val;

    void Awake()
    {
        mixer.GetFloat("MusicVol", out val);
        slider.value = Mathf.Pow(10,(val/20));
        Debug.Log(slider.value);
    }

    public void SetMusicLevel (float sliderVal)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderVal) * 20);
    }


}
