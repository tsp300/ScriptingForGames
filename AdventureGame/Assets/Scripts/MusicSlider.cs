using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    public AudioSource musicSrc;
    public Slider volumeSlider;

    private void Start()
    {
        volumeSlider.value = musicSrc.volume;
        volumeSlider.onValueChanged.AddListener(AdjustVolume);
    }

    public void AdjustVolume(float newVolume)
    {
        musicSrc.volume = newVolume;
    }
}
