using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if (Time.timeScale == 0)
        {
            
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
        }
        else
        {
            
            if (!audioSource.isPlaying)
            {
                audioSource.UnPause();
            }
        }
    }
}
