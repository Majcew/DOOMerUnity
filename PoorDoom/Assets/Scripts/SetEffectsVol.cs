using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetEffectsVol : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;

    float val;

    void Awake()
    {
        mixer.GetFloat("EffectsVol", out val);
        slider.value = Mathf.Pow(10, (val / 20));
        Debug.Log(slider.value);
    }

    public void SetEffectsLevel(float sliderVal)
    {
        mixer.SetFloat("EffectsVol", Mathf.Log10(sliderVal) * 20);
    }


}
