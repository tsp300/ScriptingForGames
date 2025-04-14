using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButton : MonoBehaviour
{
    public AudioSource musicSrc;

    public void ToggleMusic()
    {
        if (musicSrc.isPlaying)
        {
            musicSrc.Pause();
        }
        else
        {
            musicSrc.Play();
        }
    }
}
